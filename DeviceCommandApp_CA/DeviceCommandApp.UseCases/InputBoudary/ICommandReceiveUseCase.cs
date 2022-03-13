namespace DeviceCommandApp.UseCases.InputBoudary
{
    /// <summary>
    /// コマンド受信ユースケース
    /// </summary>
    public interface ICommandReceiveUseCase
    {
        void MotorMoveCommand(int Move_mm);
        void ReadSensorCommand();
    }
}
