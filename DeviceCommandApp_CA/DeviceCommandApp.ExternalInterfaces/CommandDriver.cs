using DeviceCommandApp.Common;
using DeviceCommandApp.Controllers;
using DeviceCommandApp.Util;
using System.Net.Sockets;
using System.Threading;

namespace DeviceCommandApp.ExternalInterfaces
{
    public interface ICommandDriver
    {
        public void EndThred();
    }

    /// <summary>
    /// コマンド通信ドライバ
    /// </summary>
    public class CommandDriver : ICommandDriver
    {
        private ICommandReceiveController commandReceiveController;
        private Thread Thread;
        private NetworkStream client;
        private bool execThread = true;

        public CommandDriver(ICommandReceiveController controller)
        {
            commandReceiveController = controller;
            Thread = new Thread(ThreadMain);
            Thread.Start();
        }

        public void EndThred()
        {
            this.execThread = false;
        }

        private void ThreadMain()
        {
            // TCPサーバーリスニング開始
            TcpListener listenr = new TcpListener(System.Net.IPAddress.Any, 10000);
            listenr.Start();
            while (!listenr.Pending())
            {
                Thread.Sleep(10);
                if (execThread == false)
                {
                    listenr.Stop();
                    return;
                }
            }

            var accept = listenr.AcceptTcpClient();
            client = accept.GetStream();


            while (execThread)
            {
                if (client.DataAvailable)
                {
                    // ヘッダー読み込み
                    byte[] headerbuf = new byte[CommandConstants.HeaderSize];
                    client.Read(headerbuf, 0, CommandConstants.HeaderSize);

                    // 変換
                    var header = StructConvert.ConvertToStructure<CommandHeader>(headerbuf);

                    // コマンドの中身読み込み
                    byte[] body = new byte[header.Size];
                    client.Read(body, 0, header.Size);

                    // 変換してコマンド受信を通知
                    switch (header.CommandID)
                    {
                        case CommandID.MotorCommand:
                            var motor = StructConvert.ConvertToStructure<MotorCommand>(body);
                            commandReceiveController.ReceiveMotorCommand(motor);
                            break;
                        case CommandID.SensorCommand:
                            var sensor = StructConvert.ConvertToStructure<ReadSensorCommand>(body);
                            commandReceiveController.ReceiveSensorCommand(sensor);
                            break;
                    }
                }
                else
                {
                    Thread.Sleep(10);
                }
            }

            client.Close();
            accept.Close();
            listenr.Stop();
        }
    }
}
