using BussinessLayer;
using WinForms_SystemLayer;



namespace WinFormsPresentetionLayer
{
    public partial class frmLogin : Form
    {
        Accounts_BL? CurrentAccount;

        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.None;

            txtEmailBox.Clear();
            txtPassword.Clear();
        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
            int AccountID;
            string Email = txtEmailBox.Text.Trim();
            string Password = txtPassword.Text.Trim();


            AccountID = Accounts_BL.Login(Email, Password);

            if (string.IsNullOrEmpty(Email) || string.IsNullOrEmpty(Password))
            {
                MessageBox.Show("Please Fill The Boxes", "Fill The Boxes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (AccountID != -1)
            {
                CurrentAccount = Accounts_BL.GetAccountInfo(AccountID);
                frmSystemMain frm = new frmSystemMain(AccountID);
                this.Hide();
                frm.ShowDialog();
                this.Close();
            }
            else
            {
                txtPassword.Clear();
                MessageBox.Show("Incorrect Email Or Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void btnSignin_Click(object sender, EventArgs e)
        {
            frmAddAccount frm  = new frmAddAccount();
            frm.ShowDialog();
        }
    }
}
