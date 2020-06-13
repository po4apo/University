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
    public partial class Choose_Of_Student_Negative_Qualities : Form
    {
        public Choose_Of_Student_Negative_Qualities()
        {
            InitializeComponent();
            
    }

       

        private void closeButon_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }





        public void button1_Click(object sender, EventArgs e)
        {
           
            // создаем объект University для его заполнения
            University univer = new University("");
            univer = DataBank.BufUniver;            
          
            foreach (int item in checkedListBox1.CheckedIndices)
            {
                univer.creat_int_negative_list(item);
            }
            foreach (int item in checkedListBox2.CheckedIndices)
            {
                univer.creat_int_negative_list(5 + item);
            }
            foreach (int item in checkedListBox3.CheckedIndices)
            {
                univer.creat_int_negative_list(10 + item);
            }
            foreach (int item in checkedListBox4.CheckedIndices)
            {
                univer.creat_int_negative_list(15 + item);
            }
            univer.add_inf_in_file();
            DataBank.text = Program.ConvertListToString(Program.Sort( univer.creat_answer()));
            this.Hide();
            Univer.ShowStud sS = new Univer.ShowStud();
            sS.Show();

        }
    }
    }

