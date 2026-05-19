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
            dgContacts.Columns[0].Visible = false;
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

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgContacts.CurrentRow != null)
            {
                int contactId = int.Parse(dgContacts.CurrentRow.Cells[0].Value.ToString());

                frmAddOrEdit frme = new frmAddOrEdit();
                frme.contactId = contactId;
                frme.ShowDialog();
                if (frme.DialogResult == DialogResult.OK)
                {
                    BindGrid();
                }
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (dgContacts.CurrentRow != null)
            {

                string selectedName = dgContacts.CurrentRow.Cells[1].Value.ToString();
                string selectedFamily = dgContacts.CurrentRow.Cells[2].Value.ToString();
                string selectedRowFullName = $"{selectedName} {selectedFamily}";
                string msgBoxTitle = "هشدار";
                string msgText = $"آیا از حذف کاربر " +
                    $">{selectedRowFullName}<" +
                    $"  مطمئن هستید؟";
                DialogResult res = new DialogResult();


                res = MessageBox.Show(msgText, msgBoxTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading);
                if (res == DialogResult.Yes)
                {
                    int contactId = int.Parse(  dgContacts.CurrentRow.Cells[0].Value.ToString()  );
                    repository.Delete(contactId);
                    BindGrid();


                    msgBoxTitle = "اطلاع";
                    msgText = $"آیتم کاربر " +
                        $">{selectedRowFullName}<" +
                        $" با موفقیت حذف شد.";
                    MessageBox.Show(msgText, msgBoxTitle, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading);


                }
            }
            else
            {
                string msgBoxTitle = "اطلاع";
                string msgText = "برای حذف، حتما باید یک عنصر از لیست را انتخاب نمایید.";
                MessageBox.Show(msgText, msgBoxTitle, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading);

            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dgContacts.DataSource = repository.Search(txtSearch.Text);
        }
    }
}
