using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WyrażenieUsing
{
    class SomeClass : IDisposable
    {
        public void Dispose()
        {
            Console.WriteLine("Disposing someClass");
        }

        public void Say(string input)
        {
            Console.WriteLine(input);
        }
    }
}
