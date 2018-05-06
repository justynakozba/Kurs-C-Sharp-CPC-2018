using JustynaKozbaLab4Zad1.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustynaKozbaLab4Zad1.Repositories
{
    public class Repository<T> : IRepository<T> where T : Entity
    {
        private readonly Model.AppContext context;

        public Repository(Model.AppContext context)
        {
            this.context = context;
        }

        /// <summary>
        /// Metoda odpowiadająca za tworzenie nowej pozycji w bazie
        /// </summary>
        /// <param name="entity"></param>
        public void Create(T entity)
        {
            context.Set<T>().Add(entity);
            //Jawne zapisanie zmian w bazie danych
            context.SaveChanges();

        }

        /// <summary>
        /// Metoda odpowiadająca za usuwanie danych z bazy
        /// </summary>
        /// <param name="entity"></param>
        public void Delete(T entity)
        {
            context.Set<T>().Remove(entity);
            context.SaveChanges();
        }

        /// <summary>
        /// Metoda pozwalająca na otrzymanie wszystich danych z tabeli 
        /// </summary>
        /// <returns></returns>
        public List<T> GetAll()
        {
            return context.Set<T>().ToList();

        }

        /// <summary>
        /// Metoda pozwalajca na segregacje danych po id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public T GetById(int id)
        {
            return context.Set<T>().FirstOrDefault(e => e.Id == id);
        }

        /// <summary>
        /// Metoda odpowiadająca za aktualizację danych 
        /// </summary>
        /// <param name="entity"></param>
        public void Update(T entity)
        {
            context.Entry<T>(entity).CurrentValues.SetValues(entity);
            context.SaveChanges();
        }
    }
}