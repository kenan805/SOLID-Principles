using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Open_Closed.OCPGoodWithDelegate
{
    public class SalaryCalculatorGood2
    {
        public decimal Calculate(decimal salary, Func<decimal, decimal> calculateDelegate)
        {
            return calculateDelegate(salary);
        }
    }
}
