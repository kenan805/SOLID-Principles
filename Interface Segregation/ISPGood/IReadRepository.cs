using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Segregation.ISPGood
{
    public interface IReadRepository<T>
    {
        List<T> GetList();
        T GetById(int id);

    }
}
