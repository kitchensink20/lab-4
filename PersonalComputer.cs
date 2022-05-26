using System;

namespace Lab4
{
    class PersonalComputer : Device
    {
        public PersonalComputer(string brand, decimal price, int yearOfRelease, string serialNumber)
        {
            Price = price;
            YearOfRelease = yearOfRelease;
            SerialNumber = serialNumber;
            Brand = brand;
        }
        public void ConnectMonitor(string brand, decimal price, int yearOfRelease, string serialNumber)
        {
            Device monitor = new Monitor(brand, price, yearOfRelease, serialNumber);
            Console.WriteLine("Connecting new monitor...\n");
            monitor.TurnOn();
            monitor.ShowInfo();
        }
        public void ConnectSystemUnit(string brand, decimal price, int yearOfRelease, string serialNumber)
        {
            Device systemUnit = new SystemUnit(brand, price, yearOfRelease, serialNumber);
            Console.WriteLine("Connecting new system unit...\n");
            systemUnit.TurnOn();
            systemUnit.ShowInfo();
        }
        public void DisconnectMonitor(string brand, decimal price, int yearOfRelease, string serialNumber)
        {
            Device monitor = new Monitor(brand, price, yearOfRelease, serialNumber);
            Console.WriteLine("Disconnecting monitor...\n");
            monitor.TurnOff();
        }
        public void DisconnectSystemUnit(string brand, decimal price, int yearOfRelease, string serialNumber)
        {
            Device systemUnit = new SystemUnit(brand, price, yearOfRelease, serialNumber);
            Console.WriteLine("Disconnecting system unit...\n");
            systemUnit.TurnOff();
        }
    }
}
