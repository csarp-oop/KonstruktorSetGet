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
            else
                throw new Exception(fuelQuantity + fuel + " l tankolni nem lehet, mert az autó tankájának a mérete" + tankCapacity + " l.");
        }
        public void move(int km)
        {
            if (((consumption / 100) * km)< fuelQuantity)
                 fuelQuantity -= (int) (consumption / 100 * km);
            else
               throw new Exception((consumption / 100) * km + " km-et nem lehet megtenni, mert a tankban csak " + fuelQuantity + " l üzemanyag van ");
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
            try
            {
                s.tanking(20);
                s.move(40);
                s.move(500);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine("Tank állás:" + s.getFuelQuantity());
            Console.WriteLine("Tank állás:" + s.getFuelPercent() * 100);
            Console.ReadKey();

        }
    }
}
