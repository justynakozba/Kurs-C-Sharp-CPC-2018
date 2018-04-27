using JustynaKozbaLab4.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustynaKozbaLab4.Repositories
{
    public interface IRWRepository<T> where T :Entity
    {
        List<T> GetAll();
        T GetById(int id);
        void Delete(T entity);
        void Update(T entity);
        void Create(T entity);
    }
}
