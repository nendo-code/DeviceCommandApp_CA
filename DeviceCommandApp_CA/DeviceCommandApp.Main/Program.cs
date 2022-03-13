using DeviceCommandApp.Controllers;
using DeviceCommandApp.Devices;
using DeviceCommandApp.ExternalInterfaces;
using DeviceCommandApp.Gateways;
using DeviceCommandApp.Presenters;
using DeviceCommandApp.UI;
using DeviceCommandApp.UseCases.DataAccessInterface;
using DeviceCommandApp.UseCases.InputBoudary;
using DeviceCommandApp.UseCases.OutputBoundary;
using DeviceCommandApp.UseCases.UseCaseInteractor;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Windows.Forms;

namespace DeviceCommandApp.Main
{
    static class Program
    {
        /// <summary>
        /// DI
        /// </summary>
        private static Form Build()
        {
            var services = new ServiceCollection();
            services.AddSingleton<ICommandReceiveController, CommandReceiveController>();
            services.AddSingleton<IDeviceDriver, DeviceDriver>();
            services.AddSingleton<ICommandDriver, CommandDriver>();
            services.AddSingleton<IFormDriver, Form1>();
            services.AddSingleton<IDevicePort, DevicePort>();
            services.AddSingleton<IMotorCounterRepository, MotorCounterRepository>();
            services.AddSingleton<ICommandReceiveUseCase, CommandReceiveUseCase>();
            services.AddSingleton<IUIPresenter, UIPresenter>();
            var sp = services.BuildServiceProvider();
            var form = (Form1)sp.GetService<IFormDriver>();
            form.SetCommdandDriver(sp.GetService<ICommandDriver>());
            services.BuildServiceProvider();
            return form;
        }

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(Build());
        }
    }
}
