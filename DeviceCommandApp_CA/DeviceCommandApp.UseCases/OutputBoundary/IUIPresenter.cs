namespace DeviceCommandApp.UseCases.OutputBoundary
{
    /// <summary>
    /// UI更新用Presenter
    /// </summary>
    public interface IUIPresenter
    {
        public void UpdateMotorValue(int current_mm);
        public void UpdateSensorValue(int value);
    }
}
