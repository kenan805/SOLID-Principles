using Dependency_Inversion.DIPGood;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_Inversion.DIPGood
{
    internal class ProductRepositoryFromSqlServer2 : IRepository
    {
        public List<string> GetAll()
        {
            return new List<string>() { "Sql Server Product 1", "Sql Server Product 2" };
        }
    }
}
