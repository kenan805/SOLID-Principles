using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liskov_Substitution.LSPGood
{
    public class Iphone2 : BasePhone2, ITakePhoto
    {
        public void TakePhoto()
        {
            Console.WriteLine("Photo taken");
        }
    }
}
