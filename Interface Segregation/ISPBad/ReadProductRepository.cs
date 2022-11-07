using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Segregation.ISPBad
{
    public class ReadProductRepository : IProductRepository
    {
        public Product Create(Product product)
        {
            throw new NotImplementedException(); // Exception
        }

        public Product Delete(Product product)
        {
            throw new NotImplementedException(); // Exception
        }

        public Product GetById(int id)
        {
            // some get code 
            return null; // Success
        }

        public List<Product> GetList()
        {
            // some get code
            return null; // Success
        }

        public Product Update(Product product)
        {
            throw new NotImplementedException(); // Exception
        }
    }
}
