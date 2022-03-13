using System;

namespace DeviceCommandApp.Entities
{
    /// <summary>
    /// モーターの累積移動量計算ロジック
    /// </summary>
    public class MotorCounter
    {
        public int Counter { get; private set; } = 0;
        public MotorCounter(int count)
        {
            Counter = count;
        }
        public void AddCounter(int mm)
        {
            Counter += Math.Abs(mm);
        }
    }
}
