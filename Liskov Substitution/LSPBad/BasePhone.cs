using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liskov_Substitution.LSPBad
{
    public abstract class BasePhone
    {
        public void Call()
        {
            Console.WriteLine("Call made !");
        }

        public abstract void TakePhoto();

    }
}
