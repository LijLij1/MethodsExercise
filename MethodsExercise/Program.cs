using System.Globalization;
using System.Net.Security;

namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, what is your name?");
            //string userName = Console.ReadLine();

            //Console.WriteLine("How old are you?");
            //string Age = Console.ReadLine();

            //Console.WriteLine("What is your favorite animal?");
            //string favAnimal = Console.ReadLine();

            //Console.WriteLine("What is your favorite color");
            //string favColor = Console.ReadLine();

            //Console.WriteLine($"Hello, my name is {userName}, and I am {Age} years old!");
            //Console.WriteLine($"I love to read books about animals my favorite animal is a {favAnimal}.");
            //Console.WriteLine($"Imagine if the {favAnimal} was my favorite color, it would be {favColor}!");
            //Console.WriteLine(" ");

            Console.WriteLine("Give me a number too add!");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Give me another number too add!");
            int num2 = int.Parse(Console.ReadLine());

            int sum = Sum(num1, num2);
            Console.WriteLine($"The answer is: {sum}");

            Console.WriteLine("Give me two numbers to multiply");
            num1 = int.Parse(Console.ReadLine());

            num2 = int.Parse(Console.ReadLine());

            int product = Multiply(num1, num2);
            Console.WriteLine($"The answer is: {product}");
        }
        public static int Sum(params int[] list)
        {
            int sum = 0;

            for (int i = 0; i < list.Length; i++)
            {
                sum = sum + list[i];
            }

            return sum;
        }
        public static int Multiply(int x, int y)
        {
            return x * y;
        }
    }
}