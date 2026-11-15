/*
MSSV: 202418832
Họ tên: Bùi Ngọc Trâm Anh
*/

using labw10.Interfaces;

namespace labw10.Devices
{
    public class SmartDoor : IDevice, ILockable
    {
        private readonly string _name;

        public SmartDoor(string name)
        {
            _name = name;
        }

        public void TurnOn() => Console.WriteLine($"{_name}: ON");
        public void TurnOff() => Console.WriteLine($"{_name}: OFF");
        public void Lock() => Console.WriteLine($"{_name}: LOCKED");
        public void Unlock() => Console.WriteLine($"{_name}: UNLOCKED");
    }
}
