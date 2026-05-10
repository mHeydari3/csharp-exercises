using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace csharp_exercises
{
    public partial class FirstApp__HelloWorld : Form
    {
        public FirstApp__HelloWorld()
        {
            InitializeComponent();
        }

        private void FirstApp__HelloWorld_Load(object sender, EventArgs e)
        {

        }

        private void btnSayHello_Click(object sender, EventArgs e)
        {
            if (txtInput.Text == "" || txtInput.Text == null)
            {
                lblHint.ForeColor = Color.Red;
                txtInput.Focus();
                // txtInput.Size
            }
            else
            {
                lblResult.ForeColor = Color.Green;
                lblResult.Text = "Hello `" + txtInput.Text + "`";
            }
        }
    }
}
