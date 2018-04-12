using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustynaKozbaLab2
{
    abstract class Creature
    {
        public int MaxSpeed { get; set; }
        Random random = new Random();

        public virtual int GetCurrentSpped()
        {
            int currentSpeed = random.Next(MaxSpeed);
            return currentSpeed;
        }
    }
}
