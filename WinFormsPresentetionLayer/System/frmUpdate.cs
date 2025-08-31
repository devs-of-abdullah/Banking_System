using BussinessLayer;
using clsUtil;

namespace WinForms_SystemLayer
{
    public partial class frmUpdate : Form
    {
        int CurrentID;
        Accounts_BL? Account;
        public frmUpdate(int ID)
        {
            CurrentID = ID;
            InitializeComponent();

        }

        private void frmUpdate_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.None;
            Account = Accounts_BL.GetAccountInfo(CurrentID);

        }
        bool validatePin()
        {
            if (Account != null)
            {
                if (txtNewPin.Text == "" || txtOldPin.Text == "")
                {
                    MessageBox.Show("Values Can not be empty");
                }
                if (BussinessLayer.clsUtil.ComputeHash(txtOldPin.Text) != Account.pin)
                {
                    MessageBox.Show("InCorrect pin");
                    return false;
                }

                if (txtNewPin.Text.Length != 4)
                {
                    MessageBox.Show("Pins Length must be 4 number");
                    return false;
                }
                if (!clsValidation.ValidateInteger(txtNewPin.Text) || !clsValidation.ValidateInteger(txtOldPin.Text))
                {

                    MessageBox.Show("Pins can only be integers");
                    return false;
                }if(txtNewPin.Text == txtOldPin.Text)
                {
                    MessageBox.Show("You can not change same email");
                    return false;
                }


            }
            return true;
        }

        bool validatePassword()
        {
            if (Account != null)

            {
                if (txtOldPassword.Text == "" || txtNewPassword.Text == "")
                {
                    MessageBox.Show("Values Can not be empty");
                }
                if (BussinessLayer.clsUtil.ComputeHash(txtOldPassword.Text) != Account.hashedpassword)
                {
                    MessageBox.Show("InCorrect Password");
                    return false;
                }

                if (txtNewPassword.Text.Length < 8 && txtNewPassword.Text.Length > 16)
                {
                    MessageBox.Show(" New Password Length must be more than 8 digit and less than 16 digit");
                    return false;
                }
                if (txtNewPassword.Text == txtOldPassword.Text)
                {
                    MessageBox.Show("You can not change same email");
                    return false;
                }


            }
            return true;
        }

        bool validateEmail()
        {
            if (Account != null)
            {
                if (clsValidation.ValidateEmail(txtNewEmail.Text))
                {
                    MessageBox.Show("Invalid Email syntax");
                    return false;

                }
                if (BussinessLayer.Accounts_BL.isEmailExists(txtNewEmail.Text))
                {
                    MessageBox.Show("Existed Email enter another email");
                    return false;
                }
                if (txtNewEmail.Text == Account.email)
                {
                    MessageBox.Show("you cant change with same email");
                    return false;
                }
                if(txtNewEmail.Text == "")
                {
                    MessageBox.Show("Values can not be empty");
                    return false;
                }
            }return true;
        }

        bool validateFullname()
        {
            if (Account != null)
            {
                if (txtNewFullname.Text == "")
                {
                    MessageBox.Show("Values can not be empty");
                    return false;
                }
                if (txtNewFullname.Text.Length > 16)
                {
                    MessageBox.Show("Full name can not be over than 16 character");
                    return false;
                }
            }    return true;
        }


        private void btnChangePin_Click(object sender, EventArgs e)
        {
            if (validatePin())
            {
                if (Accounts_BL.ChangePin(CurrentID, txtOldPin.Text, txtNewPin.Text))
                {
                    MessageBox.Show("Account pin changed succesfully", "pin change", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Pin not changed");
                }
            }
            return;
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            if (validatePassword())
            {
                if (Accounts_BL.ChangePassword(CurrentID, txtOldPassword.Text, txtNewPassword.Text))
                {
                    MessageBox.Show("Account password changed succesfully", "password change", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Password not changed");
                }
            }
        }



        private void btnChangeEmail_Click(object sender, EventArgs e)
        {
            if (validateEmail()) { 
                
              if(BussinessLayer.Accounts_BL.ChangeEmail(CurrentID, txtNewEmail.Text))
                {
                    MessageBox.Show("Email changed succesfully");
                }
                else
                {
                    MessageBox.Show("System Error");

                }
                
            }

        }

        private void btnChangeFullname_Click(object sender, EventArgs e)
        {
            if (validateFullname()) {

                if (BussinessLayer.Accounts_BL.ChangeFullname(CurrentID,txtNewFullname.Text))
                {
                    MessageBox.Show("Fullname Changed Succesfully");
                }
                else
                {
                    MessageBox.Show("System Error");
                }
            
            }


        }
    }
}
