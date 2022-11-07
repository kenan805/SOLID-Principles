using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_Inversion.DIPBad
{
    internal class ProductService
    {
        private readonly ProductRepositoryFromSqlServer _repository;

        public ProductService(ProductRepositoryFromSqlServer repository)
        {
            _repository = repository;
        }

        public List<string> GetAll()
        {
            return _repository.GetAll();
        }
    }
}
