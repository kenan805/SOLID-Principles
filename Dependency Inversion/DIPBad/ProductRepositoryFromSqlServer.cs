using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_Inversion.DIPBad
{
    internal class ProductRepositoryFromSqlServer
    {
        public List<string> GetAll()
        {
            return new List<string>() { "Sql Server Product 1", "Sql Server Product 2" };
        }
    }
}
