using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataFizzBuzz
{
    public interface IFizzBuzzCounter
    {
        string Translate(int input);

        IEnumerable<string> Counter(int input);
        IEnumerable<string> CounterFromReader();
    }
}
