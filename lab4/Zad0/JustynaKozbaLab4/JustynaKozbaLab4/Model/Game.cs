using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustynaKozbaLab4.Model
{
     public class Game :Entity
    {
        // to pole jest wymagane
        [Required]
        public string Name { get; set; }
        // to pole jest wymagane
        [Required]
        public string Producer { get; set; }

        //relacja jeden do wielu - jedna gra ma wiele opinii
        public virtual List<Review> Reviews { get; set; }
    }
}
