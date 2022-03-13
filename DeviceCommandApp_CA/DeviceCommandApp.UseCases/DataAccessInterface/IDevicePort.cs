namespace DeviceCommandApp.UseCases.DataAccessInterface
{
    /// <summary>
    /// デバイスアクセス
    /// </summary>
    public interface IDevicePort
    {
        public void MoveMotor(int move_distance_mm);
        public int GetSensorValue();
    }
}
