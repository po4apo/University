using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Universities_And_Studies
{
    

    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Made_selection());
            

            
    }
        static public void creat_file(string x)
        {
            StreamWriter sw = new StreamWriter(DataBank.url_stud, true, System.Text.Encoding.Default);
            sw.Write(x + "\n");
            sw.Close();            
            
        }
        
        static public void creat_file_univer(string x)
        {
            StreamWriter sw = new StreamWriter(DataBank.url_univer, true, System.Text.Encoding.Default);
            sw.Write(x + "\n");
            sw.Close();

        }
        static public string get_string(string url)
        {
            StreamReader sr = new StreamReader(url);
            string text;
            text = sr.ReadToEnd();
            return text;
        }
        static public string ConvertListToString(List<List<string>> list)
        {
            string text = "";
            for(int i = 0; i < list.Count-1; i++)
            {
                text = text + list[i][0] + "\r" + "\n";
            }
            return text;
        }
        static public int FindMaxest(List<List<string>> list)
        {
            List<string> maxest = list[0];
            int maxest_index = 0;
            for (int i = 1; i < list.Count-1; i++)
            {
                if (Convert.ToInt32(list[i][1]) > Convert.ToInt32(maxest[1]))
                {
                    maxest = list[i];
                    maxest_index = i;
                }
            }
            return maxest_index;

        
        }
        static public List<List<string>> Sort(List<List<string>> list)
        {
            List<List<string>> new_list = new List<List<string>>();
            while (list.Count > 0)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    int index = FindMaxest(list);
                    new_list.Add(list[index]);
                    list.RemoveAt(index);
                }
                
            }
            return new_list;

        }
        public enum EnumOfQualities
        {
            xрабрость,
            благородство,
            честь,
            трудолюбие,
            находчивость,
            верность,
            честность,
            ум,
            мудрость,
            остроумие,
            творчество,
            чувство_юмора,
            хитрость,
            решительность,
            амбициозность,            
            жажда_власти,
            гнев,
            чревоугодие,
            зависть,
            жадность
        }

    }
}
