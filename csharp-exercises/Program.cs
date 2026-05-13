using csharp_exercises._04_CalculatorApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace csharp_exercises
{
    class Program
    {
        //static void Main(string[] args)
        //{
        //    Console.WriteLine("Program.cs ");
        //}


        [STAThread]
        static void Main()
        {
            // فعال‌سازی استایل‌های ویندوز
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // اجرای فرم شما (به جای کد کنسولی قبلی)
            // توجه: مطمئن شوید نام کلاس فرم شما دقیقا FirstApp است
            Application.Run(new CalculatorMainForm());
            
        }


    }
}
