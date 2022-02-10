using System;

namespace KataFizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            RepeatActionOnInt(PrintFizzBuzzUntilNumber);
        }

        static void RepeatActionOnInt(Action<int> action)
        {
            while (true)
            {
                Console.WriteLine("Inserisci un numero positivo (q per uscire):");
                var input = Console.ReadLine();

                if (input == "q")
                    return;

                if (uint.TryParse(input, out var result))
                    PrintFizzBuzzUntilNumber((int)result);
                else
                    Console.WriteLine("input non valido");
            }
        }

        static void PrintFizzBuzzUntilNumber(int n)
        {
            var counter = new FizzBuzzCounter(null);
            foreach (var value in counter.Counter(n))
                Console.WriteLine(value);
        }

    }
}
