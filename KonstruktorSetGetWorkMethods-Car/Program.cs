using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KonstruktorSetGetWorkMethods_Car
{
    class Car
    {
        private string licensePlate;
        static int tankCapacity = 60;
        private int fuelQuantity;
        static double consumption = 7.8;

        public Car(string licensePlate)
        {
            this.licensePlate = licensePlate;
        }
        public void tanking(int fuel)
        {
            if (fuelQuantity + fuel <= tankCapacity)
                fuelQuantity += fuel;
        }
        public void move(int km)
        {
            if (((consumption / 100) * km)< fuelQuantity)
                 fuelQuantity -= (int) (consumption / 100 * km);
        }
        public int getFuelQuantity()
        {
            return fuelQuantity;
        }

        public double getFuelPercent()
        {
            return (double) fuelQuantity / tankCapacity;
        }
    }


    class Program
    {

        static void Main(string[] args)
        {
            Car s = new Car("AAA-111");
            s.tanking(20);
            s.move(40);
            Console.WriteLine("Tank állás:" + s.getFuelQuantity());
            Console.WriteLine("Tank állás:" + s.getFuelPercent() * 100);
            Console.ReadKey();

        }
    }
}
