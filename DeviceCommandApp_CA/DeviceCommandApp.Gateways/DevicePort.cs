using DeviceCommandApp.UseCases.DataAccessInterface;
using System;

namespace DeviceCommandApp.Gateways
{
    /// <summary>
    /// デバイスアクセスクラス
    /// </summary>
    public class DevicePort : IDevicePort
    {
        private const byte MotorAddr = 0x01;// モーターのレジスタのアドレス
        private const byte SensorAddr = 0x02;// センサーのレジスタのアドレス

        private IDeviceDriver deviceDriver;
        public DevicePort(IDeviceDriver driver)
        {
            deviceDriver = driver;
        }
        public int GetSensorValue()
        {
            return BitConverter.ToInt32(deviceDriver.ReadRegister(SensorAddr));
        }

        public void MoveMotor(int move_distance_mm)
        {
            deviceDriver.WriteRegister(MotorAddr, BitConverter.GetBytes(move_distance_mm));
        }
    }
}
