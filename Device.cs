using System;

namespace Lab4
{
    abstract class Device
    {
        public string Brand { get; set; }
        public decimal Price { get; set; }
        public string SerialNumber { get; set; }
        public int YearOfRelease { get; set; }
        public void TurnOn()
        {
            Console.WriteLine("Turning on...");
        }
        public void TurnOff()
        {
            Console.WriteLine("Turning off...");
        }
        public void Reboot()
        {
            Console.WriteLine("Rebooting the device...");
        }
        public void ShowInfo()
        { 
            Console.WriteLine($"brand: {Brand};  " +
                $"year of release: {YearOfRelease};  " +
                $"serial number: {SerialNumber};  " +
                $"price: {Price}$.");
        }
    }
}
