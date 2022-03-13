using DeviceCommandApp.ExternalInterfaces;
using DeviceCommandApp.Presenters;
using System;
using System.Windows.Forms;

namespace DeviceCommandApp.UI
{
    public partial class Form1 : Form, IFormDriver
    {
        private ICommandDriver commandDriver;
        public Form1()
        {
            InitializeComponent();
        }

        public void SetCommdandDriver(ICommandDriver driver)
        {
            commandDriver = driver;
        }

        public void Update(MainFormViewModel mainFormViewModel)
        {
            this.Invoke(new Action(
                            () =>
                            {
                                this.MotorValue.Text = mainFormViewModel.MotorValue;
                                this.SensorValue.Text = mainFormViewModel.SensorValue;
                            }));
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            commandDriver.EndThred();
        }
    }
}
