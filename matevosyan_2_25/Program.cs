using System;

namespace matevosyan_2_25
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Enter n");
            int n = int.Parse(Console.ReadLine());

            int firstSymbol = n / 100;

            int otherSymbols = n - firstSymbol * 100;

            int x = otherSymbols * 10 + firstSymbol;

            Console.WriteLine(x);
        }
    }
}
    