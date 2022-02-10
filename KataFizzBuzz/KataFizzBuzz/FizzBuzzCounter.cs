using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataFizzBuzz
{
    public class FizzBuzzCounter : IFizzBuzzCounter
    {
        private readonly IReader _reader;

        public FizzBuzzCounter(IReader reader)
        {
            _reader = reader;
        }

        public IEnumerable<string> Counter(int input) => Enumerable.Range(1, input).Select(Translate);

        public string Translate(int input)
        {
            if (input % 15 == 0)
                return "FizzBuzz";
            else if (input % 5 == 0)
                return "Buzz";
            else if (input % 3 == 0)
                return "Fizz";
            else
                return input.ToString();
        }

        public IEnumerable<string> CounterFromReader() => Counter(_reader.Read());
    }
}
