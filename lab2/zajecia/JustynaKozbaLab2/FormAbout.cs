using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JustynaKozbaLab2
{
    public partial class FormAbout : Form
    {
        public FormAbout()
        {
            InitializeComponent();
        }

        public void setLabelText(string text)
        {
            this.labelNewText.Text = text;
        }
   
        private void FormAbout_Load(object sender, EventArgs e)
        {

        }
    }
}
