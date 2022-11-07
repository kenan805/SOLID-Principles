using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Segregation.ISPGood
{
    public interface IWriteRepository<T>
    {
        T Create(T entity);
        T Update(T entity);
        T Delete(T entity);
    }
}
