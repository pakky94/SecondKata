using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataFizzBuzz
{
    public interface IReader
    {
        int Read();
    }

    public class FileReader : IReader
    {
        public FileReader(string filename)
        {

        }

        public int Read()
        {
            throw new NotImplementedException();
        }
    }
}
