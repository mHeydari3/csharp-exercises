using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using csharp_exercises._05_MyContacts.Repository;
using csharp_exercises._05_MyContacts.Services;

namespace csharp_exercises._05_MyContacts
{
    public partial class MyContactsMainForm : Form
    {
        IContactsRepository repository;
        public MyContactsMainForm()
        {
            InitializeComponent();
            repository = new ContactsRepository();
        }

        private void MyContactsMainForm_Load(object sender, EventArgs e)
        {
            BindGrid();
        }
        void BindGrid()
        {
            dgContacts.AutoGenerateColumns = false;
            dgContacts.DataSource = repository.SelectAll();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            BindGrid();
        }



        private void btnNewContact_Click(object sender, EventArgs e)
        {
            frmAddOrEdit frm = new frmAddOrEdit();
            frm.ShowDialog();
            if(frm.DialogResult == DialogResult.OK)
            {
                BindGrid();
            }
        }
    }
}
