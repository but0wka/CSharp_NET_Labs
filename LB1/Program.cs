using System;
namespace LB1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the value of x:");
            double x = Convert.ToDouble(Console.ReadLine());
            
            double result = F(x);
            
            Console.WriteLine($"F({x}) = {result}");
        }
        
        internal static double F(double x)
        {
            return x switch
            {
                < -1 => 1,
                >= -1 and <= 1 => 0,
                _ => -1
            };
        }
    }
}