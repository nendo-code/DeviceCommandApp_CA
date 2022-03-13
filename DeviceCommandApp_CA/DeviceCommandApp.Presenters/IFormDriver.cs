namespace DeviceCommandApp.Presenters
{
    /// <summary>
    /// メインフォームの表示更新用I/F
    /// </summary>
    public interface IFormDriver
    {
        public void Update(MainFormViewModel mainFormViewModel);
    }
}
