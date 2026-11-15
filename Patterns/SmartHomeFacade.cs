/*
MSSV: 202418832
Họ tên: Bùi Ngọc Trâm Anh
*/

using labw10.Interfaces;

namespace labw10.Patterns
{
    public sealed class SmartHomeFacade
    {
        private readonly IDevice _light;
        private readonly IDevice _fan;
        private readonly ILockable _door;

        public SmartHomeFacade(IDevice light, IDevice fan, ILockable door)
        {
            _light = light;
            _fan = fan;
            _door = door;
        }

        public void GoToWork()
        {
            _light.TurnOff();
            _fan.TurnOff();
            _door.Lock();
        }

        public void GoToSleep()
        {
            _fan.TurnOff();
            _door.Lock();
            _light.TurnOn();
            int level = HomeConfiguration.Instance.NightLightLevel;
            Console.WriteLine($"Night light level: {level}%");
        }
    }
}
