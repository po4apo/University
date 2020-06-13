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
    public partial class Choose_Of_Student_Qualities : Form
    {
       
        public Choose_Of_Student_Qualities()
        {
            InitializeComponent();
        }

        private void closeButon_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)

        {
            University univer = new University(textBoxName.Text);
            foreach (int item in checkedListBox1.CheckedIndices)
            {
                univer.creat_int_list(item);
            }
            foreach (int item in checkedListBox2.CheckedIndices)
            {
                univer.creat_int_list(5 + item);
            }
            foreach (int item in checkedListBox3.CheckedIndices)
            {
                univer.creat_int_list(10 + item);
            }
            foreach (int item in checkedListBox4.CheckedIndices)
            {
                univer.creat_int_list(15 + item);
            }
            
            DataBank.BufUniver = univer;
            Choose_Of_Student_Negative_Qualities choose_Of_Student_Negative_Qualities = new Choose_Of_Student_Negative_Qualities();
            this.Hide();
            choose_Of_Student_Negative_Qualities.Show();

            
            
                        
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
