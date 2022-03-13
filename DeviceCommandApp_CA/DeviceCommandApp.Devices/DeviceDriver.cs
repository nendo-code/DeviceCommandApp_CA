using DeviceCommandApp.Gateways;
using System;

namespace DeviceCommandApp.Devices
{
    /// <summary>
    /// デバイスドライバ
    /// </summary>
    public class DeviceDriver : IDeviceDriver
    {
        public void WriteRegister(byte addr, byte[] value)
        {
            // ここからHWアクセスする(ダミー)
        }

        public byte[] ReadRegister(byte addr)
        {
            // ここからHWアクセス(ダミー)
            return BitConverter.GetBytes(100);
        }
    }
}
