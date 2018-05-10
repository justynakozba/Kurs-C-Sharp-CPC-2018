namespace CarsApp.DbContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Car")]
    public partial class Car
    {
        public int CarId { get; set; }

        [Required]
        [StringLength(128)]
        public string Model { get; set; }

        [Required]
        [StringLength(50)]
        public string Manufacturer { get; set; }

        public decimal Price { get; set; }

        [StringLength(128)]
        public string Photo { get; set; }
    }
}
