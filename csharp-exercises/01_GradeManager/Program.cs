using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_exercises._01_GradeManager
{
    class Program
    {
        static void Main2(string[] args)
        {
            GradeManager gm = new GradeManager();
            List<int> listGrade = new List<int>();
            listGrade.Add(18);
            listGrade.Add(99);
            listGrade.Add(12);
            listGrade.Add(20);
            listGrade.Add(7);
            listGrade.Add(15);
            listGrade.Add(12);


            gm.AddGrade(listGrade);
            gm.PrintAll();

            gm.RemoveByValue(12);
            gm.RemoveByIndex(2);
            gm.RemoveByIndex(10);

            gm.GetAverage();
            gm.PrintMinMax();

            gm.SortAndPrint("ascending");
            gm.SortAndPrint("descending");


            Console.ReadKey();

        }
    }
}
