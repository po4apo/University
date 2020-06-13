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
    public partial class Choose_of_the_qualities : Form
    {
        public Choose_of_the_qualities()
        {
            InitializeComponent();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

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
            Abitur abitur = new Abitur(textBoxName.Text);
            foreach (int item in checkedListBox1.CheckedIndices)
            {
                abitur.creat_int_list(item);
            }
            foreach (int item in checkedListBox2.CheckedIndices)
            {
                abitur.creat_int_list(5+item);
            }
            foreach (int item in checkedListBox3.CheckedIndices)
            {
                abitur.creat_int_list(10+item);
            }
            foreach (int item in checkedListBox4.CheckedIndices)
            {
                abitur.creat_int_list(15+item);
            }
            abitur.add_inf_in_file();
            
            List<List<string>> arr = abitur.creat_answer();
            DataBank.text = Program.ConvertListToString(Program.Sort(arr));
            
            this.Hide();
            ShowUniversity showUniversity = new ShowUniversity();
            showUniversity.Show();


            
        }
    }
}
