using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoOnOOPS
{
    class Bike
    {
        //string name;
        //string color;

        public void StartEngine()
        {
            Console.WriteLine("Bike Started at " + DateTime.Now.Hour);
        }

        public void FillGas(int litre)
        {
            Console.WriteLine("Bike filled with " + litre+" litres");
        }

        public int Travel(int distance, int speed)
        {
            int time = (int)(distance / speed);
            return time;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Bike Enfield = new Bike();
            Enfield.StartEngine();
            Enfield.FillGas(6);
            Console.WriteLine("Travelled time is : "+Enfield.Travel(350, 60));
            Console.ReadKey();
        }
    }
}
