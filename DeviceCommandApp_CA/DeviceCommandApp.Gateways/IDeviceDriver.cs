namespace DeviceCommandApp.Gateways
{
    public interface IDeviceDriver
    {
        public void WriteRegister(byte addr, byte[] value);
        public byte[] ReadRegister(byte addr);
    }
}
