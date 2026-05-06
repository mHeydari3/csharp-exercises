using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QwenExercise_2
{
    class GradeManager
    {
        private List<int> _grades;
        public GradeManager() {
            this._grades = new List<int>();
        }

        public void AddGrade(int grade)
        {
            if (grade > 20 || grade < 0)
            {
                Console.WriteLine("[ERROR] نمره باید بین 0 تا 20 باشد.");
                return;
            }

            this._grades.Add(grade);
            Console.WriteLine("[ADD] Grade added successfully.");
        }

        public void AddGrade(List<int> grade)
        {
            bool everAddedAny = false;
            foreach(int num in grade)
            {
                if (num > 20 || num < 0)
                {
                    Console.WriteLine($"[ERROR] نمره باید بین 0 تا 20 باشد. یکی از مقادیر لیست ورودی شما: {num}  بوده است");

                }
                else
                {
                    this._grades.Add(num);
                    everAddedAny = true;
                }

            }

            if (everAddedAny)
            {
                Console.WriteLine("[ADD] Grades added successfully.");
            }
        }

        public void RemoveByValue(int input_grade)
        {
            foreach(int grade in this._grades)
            {
                if (grade == input_grade)
                {
                    this._grades.Remove(grade);
                    Console.WriteLine($"نمره {input_grade} حذف شد." + " [REMOVE] " );

                    break;
                }
            }

            Console.WriteLine($"نمره {input_grade} یافت نشد.");
        }

        public void RemoveByIndex(int input_index)
        {
            try
            {
                if (input_index < 0 || input_index >= this._grades.Count)
                {
                    int number_of_grade_items = this._grades.Count;
                    Console.WriteLine($" [ERROR] ایندکس {input_index} نامعتبر است. \n" +
                        $"تعداد نمرات: {number_of_grade_items}  ");
                }
                else if (this._grades.IndexOf(input_index) != null)
                {
                    this._grades.RemoveAt(input_index);
                    Console.WriteLine($"نمره در ایندکس {input_index} حذف شد." + " [REMOVE] ");
                }
                else
                {
                    Console.WriteLine("خطا ! ایندکس وارد شده ، یافت نشد!");
                }
            }
            catch(Exception e)
            {
                Console.WriteLine("خطا در تابع: \n" + e.ToString() );
            }

        }

        public void GetAverage()
        {
            double avg = 0;
            int counter = 0;

            foreach(double num in this._grades)
            {
                avg += num;
                counter++;
            }


            avg = (avg / counter);

            Console.WriteLine("[STATS] Average: " + avg.ToString() );
        }

        public void PrintMinMax()
        {
            int min = 0;
            int max = 0;

            min = Convert.ToInt32( _grades.Min()  );
            max = Convert.ToInt32( _grades.Max()  );


            Console.WriteLine($"[STATS] Min: {min} | Max: {max}");

        }

        public void PrintAll()
        {
            Console.WriteLine("[LIST] Current Grades:");
            for (int i = 0; i < this._grades.Count; i++)
            {
                Console.WriteLine($"[{i}] => {this._grades.IndexOf(i)}");
            }
        }

        public void SortAndPrint(string sorting_type)
        {
            if (sorting_type == "ascending")
            {
                Console.WriteLine("[SORT] Ascending:");
                this._grades.Sort();
                for (int i = 0; i < this._grades.Count; i++)
                {
                    Console.WriteLine($"[{i}] => {this._grades[i]}");
                }
            }else if (sorting_type == "descending")
            {
                Console.WriteLine("[SORT] Descending:");
                this._grades.Sort();
                for (int i = (this._grades.Count - 1); i >= 0 ; i--)
                {
                    Console.WriteLine($"[{i}] => {this._grades[i]}");
                }
            }
            
            
        }

        ~GradeManager(){
            Console.WriteLine("[FINAL] Total grades remaining: " + this._grades.Count);
        }
}
}
