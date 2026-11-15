/*
MSSV: 202418832
Họ tên: Bùi Ngọc Trâm Anh
*/

using labw10.Devices;
using labw10.Interfaces;

namespace labw10.Patterns
{
    public static class DeviceFactory
    {
        public static IDevice Create(string type, string name)
        {
            if (string.IsNullOrWhiteSpace(type))
                throw new ArgumentException("Device type cannot be empty.");

            return type.Trim().ToLowerInvariant() switch
            {
                "light" => new SmartLight(name),
                "fan" => new SmartFan(name),
                "door" => new SmartDoor(name),
                _ => throw new ArgumentException($"Unsupported device type: {type}")
            };
        }
    }
}
