using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liskov_Substitution.LSPBad
{
    public class Nokia3310 : BasePhone
    {
        // This phone does not support taking photos. We must throw an exception.
        public override void TakePhoto()
        {
            throw new NotImplementedException();
        }
    }
}
