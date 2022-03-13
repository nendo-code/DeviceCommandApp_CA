using DeviceCommandApp.UseCases.OutputBoundary;

namespace DeviceCommandApp.Presenters
{
    /// <summary>
    /// UI表示Presenter
    /// </summary>
    public class UIPresenter : IUIPresenter
    {
        private MainFormViewModel mainFormViewModel;
        private IFormDriver formDriver;
        public UIPresenter(IFormDriver driver)
        {
            formDriver = driver;
            mainFormViewModel = new MainFormViewModel();
        }

        public void UpdateMotorValue(int current_mm)
        {
            mainFormViewModel.MotorValue = current_mm.ToString() + "mm";
            formDriver.Update(mainFormViewModel);
        }

        public void UpdateSensorValue(int value)
        {
            mainFormViewModel.SensorValue = value.ToString() + "point";
            formDriver.Update(mainFormViewModel);
        }
    }
}
