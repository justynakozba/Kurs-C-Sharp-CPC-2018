using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JustynaKozbaLab2Zad1
{
    class Vegetable
    {
        public Form parent;

        public void draw()
        {
            Label test = new Label();
            test.Text = "TEST labelki sdlugi napis wisoczny";
            test.Parent = parent;
            test.Location = new System.Drawing.Point(317, 119 +  26);
            test.Size = new System.Drawing.Size(77, 21);
        }
    }
}
