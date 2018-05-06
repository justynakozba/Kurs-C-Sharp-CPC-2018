using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustynaKozbaLab4.Model
{
    public class AppContext : DbContext
    {
        /// <summary>
        /// AppContext - to jest nazwa connection stringa w App.config
        /// </summary>
        public AppContext() : base("AppContext")
        {

        }

        //klasy, które zostaną zmapowane na tabele
        public virtual DbSet<Review>  Review{ get; set; }
        public virtual DbSet<Game> Game { get; set; }
    }
}
