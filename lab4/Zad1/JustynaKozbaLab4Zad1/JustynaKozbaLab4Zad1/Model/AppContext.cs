using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace JustynaKozbaLab4Zad1.Model
{
    public class AppContext : DbContext
    {
        public AppContext() : base("AppContext")
        {

        }
        public virtual DbSet<Customers> Customer { get; set; }
        public virtual DbSet<Orders> Order { get; set; }
        public virtual DbSet<Invoices> Invoice { get; set; }
    }
}
