using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liskov_Substitution.LSPGood
{
    public class Nokia33102 : BasePhone2
    {
        // This phone does not support taking photos. We don't inherit from the ITakePhoto interface and don't have to write any needless methods.
    }
}
