using System.ComponentModel;

namespace SwapProgram
{ public class Swap
    {
        int a, b, temp; 
        public void swapNumbers()
        {
            Console.WriteLine("enter value for A");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter value for B");
            int b = Convert.ToInt32(Console.ReadLine());
            temp =a; a=b; b=temp;
            Console.WriteLine("Now A is :" + a);
            Console.WriteLine("Now B is :" + b);
        }
        
    }
    internal class Program
    {
        static void Main(string[] args)
         {
            
            Swap swap = new Swap();
            swap.swapNumbers(); 
           
        }
    }
}