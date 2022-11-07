using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liskov_Substitution.LSPBad
{
    public class Iphone : BasePhone
    {
        public override void TakePhoto()
        {
            Console.WriteLine("Photo taken");
        }
    }
}
