namespace CarsApp.DbContext
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DataBaseContext : DbContext
    {
        public DataBaseContext()
            : base("name=DataBaseContext")
        {
        }

        public virtual DbSet<Car> Car { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Car>()
                .Property(e => e.Price)
                .HasPrecision(18, 0);
        }
    }
}
