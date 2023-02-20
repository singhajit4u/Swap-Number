using System.Transactions;

namespace Swap_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Value of first number: {num1}" + $" Value Of second number: {num2}");

            int num3 = num1;
            num1 = num2;
            num2 = num3; 
            Console.WriteLine($"After Swap Value Of first number: {num1}" + $"and Value Of second number: {num2}");
            Console.ReadLine();
        }
    }
}