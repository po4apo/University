using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Universities_And_Studies
{
    public class Abitur
    {
        string name;
        List<int> student_qualities = new List<int>(){};

        public Abitur(string name)
        {
            this.name = name;
        }

        public void creat_int_list(int index) 
        {
            this.student_qualities.Add(index);        
            
        }
        public void add_inf_in_file()
        {
            
            string all_inf = this.name + " " ;
            foreach (int item in this.student_qualities)
            {
                all_inf = all_inf + item.ToString() + " ";
            }
            all_inf = all_inf + "* ";
            Program.creat_file(all_inf);
        }

        public List<List<string>> creat_answer()
        {
            string[] text;
            List<List<string>> result = new List<List<string>>() { };
            string answer = Program.get_string(DataBank.url_univer);            
            //Console.WriteLine(answer);
            text = answer.Split(' ');
            //переменная для подсчета строк
            int line = 0;
            //переменная для подсчёта индекса списка с записями в списке списков
            int i = 0;
            //баллы на основании, которых будет строится рейтинг
            //за каждый положительное качества +1
            //за отсутсвие нежелательного качества +1
            int ball = 0;
            //создаем список с названием университета и баллов сходимости
            foreach(string item in text)
            {
                //после прохождения негативных качеств за счет №2 line будет равен 3 
                //за счет этого весь цикл начнется с начала
                if (line > 2) 
                { 
                    line = 0;                  
                    result[i - 1].Add(Convert.ToString(ball));
                    ball = 0;

                }
                //2.при переходе с одной строки на другую качества меняются с положительных на отрицательные
                if (item == "*\n") { line++; continue; }
                //1.создаем список с названием университета, позже добавим в этот список балл
                if (line == 0)
                    
                {                    
                    result.Add(new List<string> { item });
                    i++;
                    line = 1;
                    continue;
                        }
                //3.в этом условии мы проверяем все качества которые написанны от имени и до переноса строки
                // это обеспечивается №2
                if (line == 1) 
                {
                    foreach (int qu in this.student_qualities)
                    {

                        
                        if (Convert.ToInt32(item) == qu) { ball++; }
                    }
                }
                //4. В этом условии проверяются все негативные качества, за присутствие которых дают минус балл
                if (line == 2)
                {
                    foreach (int qu in this.student_qualities)
                    {

                        Console.WriteLine("qu=" + qu + "\n" + "item=" + item);
                        if (Convert.ToInt32(item) == qu) {
                            ball--; }
                    }
                }

            }

            return result;
        }
        

    }
}
