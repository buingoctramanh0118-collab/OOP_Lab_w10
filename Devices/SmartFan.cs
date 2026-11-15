/*
MSSV: 202418832
Họ tên: Bùi Ngọc Trâm Anh
*/

using labw10.Interfaces;

namespace labw10.Devices
{
    public class SmartFan : IDevice
    {
        private readonly string _name;

        public SmartFan(string name)
        {
            _name = name;
        }

        public void TurnOn() => Console.WriteLine($"{_name}: ON");
        public void TurnOff() => Console.WriteLine($"{_name}: OFF");
    }
}
