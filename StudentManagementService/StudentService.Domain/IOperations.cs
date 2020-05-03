using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentService.Domain
{
    public interface IOperations<T> where T: class
    {
        void Create(T t);

        void Update(T t);

        bool Delete(int id);

        IEnumerable<T> GetAll();

        T Get(int id);
    }
}
