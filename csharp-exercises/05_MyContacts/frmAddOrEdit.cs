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
    public partial class frmAddOrEdit : Form
    {
        IContactsRepository repository;
        public int contactId = 0;
        public frmAddOrEdit()
        {
            InitializeComponent();
            repository = new ContactsRepository();
        }


        bool ValidateInputs()
        {
            
            string msgText = "";
            string msgBoxTitle = "هشدار";
            if (txtName.Text == "")
            {                
                msgText = "لطفا مقدار فیلد نام را وارد فرمایید.";
                MessageBox.Show(msgText, msgBoxTitle, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1,  MessageBoxOptions.RtlReading);
                return false;
            }
            if(txtFamily.Text == "")
            {
                msgText = "لطفا مقدار فیلد نام‌خانوادگی را وارد فرمایید.";
                MessageBox.Show(msgText, msgBoxTitle, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading);
                return false;
            }
            if (txtMobile.Text == "")
            {
                msgText = "لطفا مقدار فیلد موبایل را وارد فرمایید.";
                MessageBox.Show(msgText, msgBoxTitle, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading);
                return false;
            }
            if (txtAge.Value == 0)
            {
                msgText = "لطفا مقدار فیلد سن را وارد فرمایید.";
                MessageBox.Show(msgText, msgBoxTitle, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading);
                return false;
            }
            if (txtEmail.Text == "")
            {
                msgText = "لطفا مقدار فیلد ایمیل را وارد فرمایید.";
                MessageBox.Show(msgText, msgBoxTitle, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading);
                return false;
            }
            if (txtAddress.Text == "")
            {
                msgText = "لطفا مقدار فیلد آدرس را وارد فرمایید.";
                MessageBox.Show(msgText, msgBoxTitle, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading);
                return false;
            }


            return true;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            bool isEditMode = false;
            if (contactId != 0)
            {
                isEditMode = true;
            }

            if (ValidateInputs())
            {
                if (isEditMode == true)
                {
                    bool isSuccess = repository.Update(contactId, txtName.Text, txtFamily.Text, txtMobile.Text, txtEmail.Text, (int)txtAge.Value, txtAddress.Text);
                    if (isSuccess == true)
                    {
                        string FullName = txtName.Text.ToString() + " " + txtFamily.Text.ToString();
                        string msgBoxTitle = "اطلاع";
                        string msgText = $"عملیات ویرایش شخص " +
                            $">{FullName}<" +
                            $"  در دفتر تلفن با موفقیت صورت پذیرفت!";
                        MessageBox.Show(msgText, msgBoxTitle, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading);
                        DialogResult = DialogResult.OK;


                    }
                    else
                    {
                        string msgBoxTitle = "هشدار";
                        string msgText = "عملیات ویرایش شخص در دفتر تلفن با شکست مواجه شد.";
                        MessageBox.Show(msgText, msgBoxTitle, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading);
                    }
                }
                else
                {
                    bool isSuccess = repository.Insert(txtName.Text, txtFamily.Text, txtMobile.Text, txtEmail.Text, (int)txtAge.Value, txtAddress.Text);
                    if (isSuccess == true)
                    {
                        string msgBoxTitle = "اطلاع";
                        string msgText = "عملیات افزودن شخص جدید به دفتر تلفن با موفقیت صورت پذیرفت!";
                        MessageBox.Show(msgText, msgBoxTitle, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading);
                        DialogResult = DialogResult.OK;


                    }
                    else
                    {
                        string msgBoxTitle = "هشدار";
                        string msgText = "عملیات افزودن شخص جدید به دفتر تلفن با شکست مواجه شد.";
                        MessageBox.Show(msgText, msgBoxTitle, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading);
                    }

                }
            }
        }

        private void frmAddOrEdit_Load(object sender, EventArgs e)
        {
            if (contactId == 0)
            {
                this.Text = "افزودن شخص جدید";
                lblFormTitle.Text = "عملیات افزودن شخص جدید";
            }
            else
            {
                this.Text = "ویرایش شخص از لیست";
                lblFormTitle.Text = "عملیات ویرایش شخص از لیست";
                DataTable dt = repository.SelectRow(contactId);
                txtName.Text = dt.Rows[0][1].ToString();
                txtFamily.Text = dt.Rows[0][2].ToString();
                txtMobile.Text = dt.Rows[0][3].ToString();
                txtEmail.Text = dt.Rows[0][4].ToString();
                txtAge.Text = dt.Rows[0][5].ToString();
                txtAddress.Text = dt.Rows[0][6].ToString();
            }
        }
    }
}
