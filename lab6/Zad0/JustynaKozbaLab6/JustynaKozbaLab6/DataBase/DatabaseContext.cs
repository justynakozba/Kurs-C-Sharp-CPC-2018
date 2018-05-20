namespace JustynaKozbaLab6.DataBase
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DatabaseContext : DbContext
    {
        public DatabaseContext()
            : base("name=DatabaseContext")
        {
        }

        public virtual DbSet<Bike> Bike { get; set; }
        public virtual DbSet<Order> Order { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Bike>()
                .Property(e => e.Price)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Bike>()
                .HasMany(e => e.Order)
                .WithRequired(e => e.Bike)
                .WillCascadeOnDelete(false);
        }
    }
}
