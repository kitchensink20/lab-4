using System;

namespace Lab4
{
    class SystemUnit : PersonalComputer
    {
        public SystemUnit(string brand, decimal price, int yearOfRelease, string serialNumber) : base(brand, price, yearOfRelease, serialNumber)
        {
            Price = price;
            YearOfRelease = yearOfRelease;
            SerialNumber = serialNumber;
            Brand = brand;
        }
    }
}
