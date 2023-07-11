namespace EvenOrOddprogram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number that you want to check");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num % 2 == 0)
                Console.WriteLine("Given number is even");
            else
                Console.WriteLine(" Givennumber is odd ");
        }
    }
}