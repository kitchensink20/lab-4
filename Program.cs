//Створити суперклас Гаджет і підкласи Персональний комп’ютер, Системний блок, Монітор, Смартфон. 
//За допомогою конструктора задати вартість кожного гаджета. 
//Реалізувати можливість під’єднання та відключення класів-комплектуючих 
//до персонального комп’ютера та функцію перезавантаження гаджета.
using System;

namespace Lab4
{
    internal class Program
    {
        static void Main()
        {
            Device smartphone1 = new Smartphone("samsung", 800, 2022, "GM2929");
            Device smartphone2 = new Smartphone("apple", 1200, 2020, "QP2290");
            Device personalComputer = new PersonalComputer("lenovo", 1800, 2021, "UL320");
            Device systemUnit = new SystemUnit("acer", 400, 2020, "QT23214");
            Device monitor1 = new Monitor("lg", 250, 2021, "MK39238");
            Device monitor2 = new Monitor("samsung", 300, 2019, "DR2899");
            ShopOfDevices newShop = new ShopOfDevices(smartphone1, smartphone2, systemUnit, monitor1, monitor2, personalComputer);
            
            newShop.ShowInfo();
            newShop.FindBrand();
            newShop.FindByCategory();

            Console.WriteLine("\nWould you like to add new device?(yes|no)");
            string yesOrNo = Console.ReadLine();
            if (yesOrNo == "yes")
                newShop.AddNewDevice();

            newShop.CountFullPrice();
           
            Console.ReadKey();    
        }
    }
}
