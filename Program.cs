/*
MSSV: 202418832
Họ tên: Bùi Ngọc Trâm Anh
*/

using labw10.Devices;
using labw10.Interfaces;
using labw10.Patterns;

Console.WriteLine("TEST CASES\n");

Console.WriteLine("[T1] Tao thiet bi qua DeviceFactory:");
IDevice light = DeviceFactory.Create("LIGHT", "Living room light");
IDevice fan = DeviceFactory.Create("fan", "Living room fan");
IDevice door = DeviceFactory.Create("Door", "Main door");

if (light is SmartLight && fan is SmartFan && door is SmartDoor)
    Console.WriteLine("-> PASS: Tra ve dung kieu doi tuong SmartLight, SmartFan, SmartDoor.\n");
else
    throw new Exception("T1 Failed!");

Console.WriteLine("[T2] Tao thiet bi chua ho tro ('camera'):");
try
{
    IDevice cam = DeviceFactory.Create("camera", "Garage cam");
    throw new Exception("T2 Failed: Khong phat sinh ArgumentException!");
}
catch (ArgumentException ex)
{
    Console.WriteLine($"-> PASS: Da bat duoc ArgumentException -> {ex.Message}\n");
}

Console.WriteLine("[T3] Kiem tra Singleton HomeConfiguration:");
var c1 = HomeConfiguration.Instance;
var c2 = HomeConfiguration.Instance;
if (!ReferenceEquals(c1, c2))
{
    throw new Exception("Singleton implementation is incorrect.");
}
Console.WriteLine($"-> PASS: ReferenceEquals(c1, c2) = {ReferenceEquals(c1, c2)}\n");
 
var facade = new SmartHomeFacade(light, fan, (ILockable)door);

Console.WriteLine("[T4] Goi facade.GoToWork():");
facade.GoToWork();

Console.WriteLine("\n[T5] Goi facade.GoToSleep():");
facade.GoToSleep();

Console.WriteLine("\nEND");
