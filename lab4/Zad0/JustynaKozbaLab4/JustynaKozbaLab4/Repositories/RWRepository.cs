using JustynaKozbaLab4.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustynaKozbaLab4.Repositories
{
    public class RWRepository<T> : IRWRepository<T> where T : Entity
    {
        private readonly Model.AppContext context;

        public RWRepository(Model.AppContext context)
        {
            this.context = context;
        }

        public void Create(T entity)
        {
            context.Set<T>().Add(entity);
            //Jawne zapisanie zmian w bazie danych
            context.SaveChanges();
        }

        public void Delete(T entity)
        {
            throw new NotImplementedException();
        }

        public List<T> GetAll()
        {
            return context.Set<T>().ToList();

        }

        public T GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
