using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace csharp_exercises._04_CalculatorApp
{
    public partial class CalculatorMainForm : Form
    {
        ICalculate calculate = new Calculate() ;

        public CalculatorMainForm()
        {
            InitializeComponent();
        }

        private void CalculatorMainForm_Load(object sender, EventArgs e)
        {

        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            if (  ValidateInputs()  )
            {
                int sum = calculate.Plus((int)txtNumber1.Value, (int)txtNumber2.Value);
                MessageBox.Show("Sum result: " + sum);
            }
        }

        bool ValidateInputs()
        {

            bool isValid = true;

            if (txtNumber1.Value == 0)
            {
                isValid = false;
                MessageBox.Show("لطفا عدد اول را وارد کنید");
            }
            else if (txtNumber2.Value == 0)
            {
                isValid = false;
                MessageBox.Show("لطفا عدد دوم را وارد کنید");
            }

            return isValid;
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            if (ValidateInputs())
            {
                int minus = calculate.Minus(   int.Parse(txtNumber1.Value.ToString()  ) , int.Parse(txtNumber2.Value.ToString()  )    );
                MessageBox.Show("Minus result: " + minus);
            }
        }

        private void btnMultiple_Click(object sender, EventArgs e)
        {
            if (ValidateInputs())
            {
                int multiple = calculate.Mutiple((int)txtNumber1.Value, (int)txtNumber2.Value);
                MessageBox.Show("Multiple result: " + multiple);
            }
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            if (ValidateInputs())
            {
                int divide = calculate.Divide((int)txtNumber1.Value, (int)txtNumber2.Value);
                MessageBox.Show("Multiple result: " + divide);
            }
        }
    }
}
