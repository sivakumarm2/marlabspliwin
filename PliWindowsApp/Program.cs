using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace PliWindowsApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome Continuous Integration using TeamCity");
            Console.WriteLine("Please enter  number 1");
            int i=int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter number 2");
            int j = int.Parse(Console.ReadLine());
            Console.WriteLine("The sum of two numbers is");
            Console.WriteLine(Calculation.AddNumbers(i, j));
            Console.ReadLine();
            
        }

        
    }

    public class Calculation
    {
        public static int AddNumbers(int a, int b)
        {
            return a + b;
        }
    }
}
