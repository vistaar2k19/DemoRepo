using System;

namespace ConsoleApp4
{
    class Program
    {
        njhdjahd
        static void Main(string[] args)
        {
            int pizza = 200;
            int puff = 40;
            int pepsi = 120;
            Console.WriteLine("Enter the no of pizzas bought :");
            int pizzas = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the no of puffs bought :");
            int puffs = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the no of pepsi bought :");
            int pepsis = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Bill Details");
            int a = pizzas * pizza;
            int b = puffs * puff;
            int c = pepsi * pepsis;
            Console.WriteLine("Cost of pizzas :" + a);
            Console.WriteLine("Cost of puffs :" + b);
            Console.WriteLine("Cost of pepsis :" + c);
            int Total_Price = a + b + c;
            double d = (12 * Total_Price) / 100;
            double e= (5 * Total_Price) / 100;
            Console.WriteLine("GST 12% : " +d);
            Console.WriteLine("CESS 5% : " +e);
            Console.WriteLine("Total Price : " + Total_Price);
        }

    }
}
