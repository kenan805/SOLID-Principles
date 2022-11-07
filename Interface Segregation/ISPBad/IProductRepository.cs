using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Segregation.ISPBad
{
    public interface IProductRepository
    {
        List<Product> GetList();
        Product GetById(int id);
        Product Create(Product product);
        Product Update(Product product);
        Product Delete(Product product);
    }
}
