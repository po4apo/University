using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Universities_And_Studies
{
    public class University
    {
        string name;
        List<int> student_qualities = new List<int>() { };
        List<int> student_negative_qualities = new List<int>() { };

        public University(string name)
        {
            this.name = name;
        }

        public void creat_int_list(int index)
        {
            this.student_qualities.Add(index);

        }

        public void creat_int_negative_list(int index)
        {
            this.student_negative_qualities.Add(index);

        }
        public void add_inf_in_file()
        {

            string all_inf = " " + this.name + " ";
            foreach (int item in this.student_qualities)
            {
                all_inf = all_inf + item.ToString() + " ";
            }
            all_inf = all_inf + "*\n ";
            foreach (int item in this.student_negative_qualities)
            {
                all_inf = all_inf + item.ToString() + " ";
            }
            all_inf = all_inf + "*";
            Program.creat_file_univer(all_inf);
        }
        public List<List<string>> creat_answer()
        {
            string answer = Program.get_string(DataBank.url_stud);
            string[] text ;
            List<List<string>> result = new List<List<string>>() { };
            text = answer.Split(' ');
            int ball = 0;
            bool line = true;
            int i = 0;
            foreach (string item in text)
            {
                if (item == "*")
                {
                    line = true;
                    result[i - 1].Add(ball.ToString());
                    continue;

                }
                if (line)
                {
                    result.Add(new List<string> { item });
                    line = false;
                    i++;
                    continue;
                }
                if (line == false)
                {
                    foreach (int qu in this.student_qualities)
                    {
                        Console.WriteLine("item=" + item); 
                        Console.WriteLine("qu=" + qu);
                        if (Convert.ToInt32(item) == qu) { ball++; }
                    }
                    foreach (int qu in this.student_negative_qualities)
                    {
                        if (Convert.ToInt32(item) == qu) { ball--; }
                    }
                }
                
            }
            Console.WriteLine(Program.ConvertListToString(result));
            return result;
        }

    }
}
