using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Universities_And_Studies
{
    public partial class Made_selection : Form
    {
        public Made_selection()
        {
            InitializeComponent();
        }

        private void closeButon_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        
        private void buttonNext_Click(object sender, EventArgs e)
        {
            
         
            if (!radioStud.Checked) 
            {
                this.Hide();
                Choose_of_the_qualities choose_Of_The_Qualities = new Choose_of_the_qualities();
                choose_Of_The_Qualities.Show();
            }
            else
            {
                this.Hide();
                Choose_Of_Student_Qualities choose_Of_Student_Qualities = new Choose_Of_Student_Qualities();
                choose_Of_Student_Qualities.Show();

            }
        }
    }
}
