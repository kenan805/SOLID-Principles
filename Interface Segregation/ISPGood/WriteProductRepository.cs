using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Segregation.ISPGood
{
    public class WriteProductRepository : IWriteRepository<Product>
    {
        public Product Create(Product entity)
        {
            throw new NotImplementedException();
        }

        public Product Delete(Product entity)
        {
            throw new NotImplementedException();
        }

        public Product Update(Product entity)
        {
            throw new NotImplementedException();
        }
    }
}
