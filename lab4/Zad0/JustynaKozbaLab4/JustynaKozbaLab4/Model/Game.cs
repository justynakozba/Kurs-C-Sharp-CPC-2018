using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustynaKozbaLab4.Model
{
     public class Game :Entity
    {
        public string Name { get; set; }
        public string Producer { get; set; }
        public virtual List<Review> Review { get; set; }
    }
}
