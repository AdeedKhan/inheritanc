using System.Drawing;
using System.Xml.Schema;

namespace Inheritance
{
    //internal class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        //Console.WriteLine("Hello, World!");
    //        Car myCar = new Car();
    //        myCar model = "Ferrari";
    //        myCar Color = "Black";
    //        myCar price = "30000000";
    //    }
    //}

    class Car
    {
        public string model;
        public string color;
        public int price;

        public void PrintCarInformation()
        {
            Console.WriteLine("Model:" + model);
            Console.WriteLine("Color:" + color);
            Console.WriteLine("Price:" + price);
        }
    }
    class Ferrari : Car
    {
        public int speed;

        public void PrintSpeed()
        {
            Console.WriteLine("Speed:" + speed);
        }
    }
    class Maruti : Ferrari
    {
        float mileage;
        void PrintMileage()
        {
            Console.WriteLine("Mileage:" + mileage);
        }
        public static void Main(string[] args)
        {
            Maruti myCar = new Maruti();
            myCar.model = "Alto";
            myCar.color = "red";
            myCar.price = 200000;
            myCar.mileage = 22.5f;
            myCar.speed = 200;
            myCar.PrintCarInformation();
            myCar.PrintMileage();
            myCar.PrintSpeed();
            Console.ReadLine();
        }
    }

}
