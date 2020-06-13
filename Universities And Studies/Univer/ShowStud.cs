using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Universities_And_Studies.Univer
{
    public partial class ShowStud : Form
    {
        public ShowStud()
        {
            
            textBox1.Text  = DataBank.text;
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
