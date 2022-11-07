using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Open_Closed.OCPGood
{
    public class MiddleSalaryCalculate2 : ISalaryCalculate2
    {
        public decimal Calculate(decimal salary)
        {
            return salary * 4;
        }
    }
}
