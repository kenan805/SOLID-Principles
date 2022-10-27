using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Single_Responsibility.SRPGood
{
    public class ProductPresenter
    {
        public void WriteToConsole(List<Product> productList)
        {
            productList.ForEach(p =>
            {
                Console.WriteLine($"{p.Id} - {p.Name}");
            });
        }
    }
}
