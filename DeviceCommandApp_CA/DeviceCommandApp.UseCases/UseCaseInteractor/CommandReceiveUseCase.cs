using DeviceCommandApp.Entities;
using DeviceCommandApp.UseCases.DataAccessInterface;
using DeviceCommandApp.UseCases.InputBoudary;
using DeviceCommandApp.UseCases.OutputBoundary;

namespace DeviceCommandApp.UseCases.UseCaseInteractor
{
    /// <summary>
    /// コマンド受信ユースケース
    /// </summary>
    public class CommandReceiveUseCase : ICommandReceiveUseCase
    {
        private IUIPresenter presenter;
        private IDevicePort devicePort;
        private IMotorCounterRepository motorCounterRepository;
        public CommandReceiveUseCase(IUIPresenter uiPresenter, IDevicePort device, IMotorCounterRepository motorCounter)
        {
            presenter = uiPresenter;
            devicePort = device;
            motorCounterRepository = motorCounter;
        }

        public void MotorMoveCommand(int Move_mm)
        {
            devicePort.MoveMotor(Move_mm);

            var counter = motorCounterRepository.ReadCounter();
            var motorCounter = new MotorCounter(counter);
            motorCounter.AddCounter(Move_mm);
            motorCounterRepository.SaveCounter(motorCounter.Counter);

            presenter.UpdateMotorValue(motorCounter.Counter);
        }

        public void ReadSensorCommand()
        {
            var val = devicePort.GetSensorValue();
            presenter.UpdateSensorValue(val);
        }
    }
}
