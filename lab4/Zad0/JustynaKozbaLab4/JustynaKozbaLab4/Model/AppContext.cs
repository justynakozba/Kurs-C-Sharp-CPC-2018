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
        public AppContext() : base("AppContext")
        {

        }
        public virtual DbSet<Review>  Review{ get; set; }
        public virtual DbSet<Game> Game { get; set; }
    }
}
