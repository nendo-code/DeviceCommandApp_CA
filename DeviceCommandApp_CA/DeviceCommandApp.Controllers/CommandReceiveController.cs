using DeviceCommandApp.Common;
using DeviceCommandApp.UseCases.InputBoudary;

namespace DeviceCommandApp.Controllers
{
    public interface ICommandReceiveController
    {
        void ReceiveMotorCommand(MotorCommand command);
        void ReceiveSensorCommand(ReadSensorCommand command);
    }

    /// <summary>
    /// コマンド受信コントローラ
    /// </summary>
    public class CommandReceiveController : ICommandReceiveController
    {
        private ICommandReceiveUseCase commandReceiveUseCase;

        public CommandReceiveController(ICommandReceiveUseCase usecase)
        {
            commandReceiveUseCase = usecase;
        }

        public void ReceiveMotorCommand(MotorCommand command)
        {
            commandReceiveUseCase.MotorMoveCommand(command.Move_mm);
        }
        public void ReceiveSensorCommand(ReadSensorCommand command)
        {
            commandReceiveUseCase.ReadSensorCommand();
        }
    }
}
