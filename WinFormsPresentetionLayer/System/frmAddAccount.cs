using BussinessLayer;
using clsUtil;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsPresentetionLayer;

namespace WinForms_SystemLayer
{
    public partial class frmAddAccount : Form
    {
        public frmAddAccount()
        {
            InitializeComponent();
        }
        bool Validation()
        {
            if(txtfullname.Text == "" || txtEmail.Text == "" || txtPassword.Text =="" || txtPin.Text == "")
            {
               MessageBox.Show("Values can not be empty", "empty values",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false; 
            } 
            if (!clsValidation.ValidateEmail(txtEmail.Text)) {
                MessageBox.Show("Invalid Email", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (txtPassword.Text.Length < 8 || txtPassword.Text.Length >16)
            {
                MessageBox.Show("Password Length must be more than 8 and less than 16 digits");
                return false;
            }
            if (txtPin.Text.Length != 4 ) {
                MessageBox.Show("Pin must be 4 Number");
                return false;
            }
           if(!clsValidation.ValidateInteger(txtPin.Text) )
            {
                MessageBox.Show("pin can only include integer");
                return false;
            }
            if (txtfullname.Text.Length > 16) {
                MessageBox.Show("Full name can not be over than 16 character");
                return false;
            }
            return true;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (Validation())
            {
                if (MessageBox.Show("Do You confirm The Information", "Confirm Adding", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {



                    int NewID = Accounts_BL.AddNewAccount(txtfullname.Text, txtPin.Text, txtEmail.Text, txtPassword.Text);
                    if (NewID != -1)
                    {
                        MessageBox.Show($"Account Added Succesfully, Your ID is {NewID}", "Succes Adding", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        frmSystemMain frm = new frmSystemMain(NewID);
                        frm.ShowDialog();
                        txtEmail.Text = ""; txtfullname.Text = ""; txtPin.Text = ""; txtPassword.Text = "";
                    }




                    return;
                }
                return;
            }
        }

        private void frmAddAccount_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.None;
        }
    }
}
