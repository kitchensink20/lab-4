using System;

namespace Lab4
{
    class Smartphone : Device
    {
        public Smartphone(string brand, decimal price, int yearOfRelease, string serialNumber)
        {
            Price = price;
            YearOfRelease = yearOfRelease;
            SerialNumber = serialNumber;
            Brand = brand;
        }
    }
}
