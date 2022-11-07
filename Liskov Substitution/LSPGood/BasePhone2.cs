using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liskov_Substitution.LSPGood
{
    public abstract class BasePhone2
    {
        public void Call()
        {
            Console.WriteLine("Call made !");
        }

    }
}
