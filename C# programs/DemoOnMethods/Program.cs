using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoOnMethods
{
    class Calculator
    {
        int val1;
        int val2;

        public int Val1 { get => val1; set => val1 = value; }

        public int Val2 { get => val2; set => val2 = value; }


        public Calculator()
        { }

        public Calculator(int val1, int val2)
        {
            this.val1 = val1;
            this.val2 = val2;
            Console.WriteLine("val1 : " + val1 + "  val2 : " + val2);
        }

        public int Add(int num1, int num2)      //call by value
        {
            //Console.WriteLine("Addition is : " + (num1 + num2));
            return (num1 + num2);
        }

        public void Swap(int num1, int num2)      //call by reference
        {
            int temp = num1;
            num1 = num2;
            num2 = temp;
            Console.WriteLine("Swapping : " + num1 + " " + num2);
        }

        public void Swap(ref int num1, ref int num2)
        {
            int temp = num1;
            num1 = num2;
            num2 = temp;
            Console.WriteLine("Swapping : " + num1 + " " + num2);
        }

        public void Subtract(int num1, int num2, out int res)
        {
            //Console.WriteLine("Addition is : " + (num1 + num2));
            res = num1 - num2;

        }
        class Program
        {
            static void Main(string[] args)
            {
                Calculator cl = new Calculator();
                Console.WriteLine("Enter x,y values : ");
                int x = int.Parse(Console.ReadLine());
                int y = int.Parse(Console.ReadLine());
                /*cl.Add(x, y);
                cl.Swap(x, y);*/
                cl.Subtract(x, y, out int sub);
                Console.WriteLine("Subtraction is : " + sub);
                Console.WriteLine("Addition is : " +cl.Add(x, y));
                cl.Swap(ref x, ref y);
                Console.WriteLine("Final Values of X : " + x + "\tY : " + y);
                Console.ReadKey();
            }
        }
    }
}

