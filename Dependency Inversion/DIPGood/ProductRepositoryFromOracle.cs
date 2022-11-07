using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_Inversion.DIPGood
{
    internal class ProductRepositoryFromOracle : IRepository
    {
        public List<string> GetAll()
        {
            return new List<string>() { "Oracle Product 1", "Oracle Product 2" };
        }
    }
}
