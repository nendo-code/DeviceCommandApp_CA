namespace DeviceCommandApp.UseCases.DataAccessInterface
{
    /// <summary>
    /// モーター累積移動量リポジトリ
    /// </summary>
    public interface IMotorCounterRepository
    {
        void SaveCounter(int data);
        int ReadCounter();
    }
}
