using BussinessLayer;
using WinForms_SystemLayer;


namespace WinFormsPresentetionLayer
{
    public partial class frmSystemMain : Form
    {
        Accounts_BL? currentAccount;

        public frmSystemMain(int AccountID)
        {
            InitializeComponent();
            currentAccount = Accounts_BL.GetAccountInfo(AccountID);
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.None;
            if (currentAccount != null)
            {
                lblAccountID.Text = currentAccount.AccountId.ToString();
                lblfullname.Text = currentAccount.fullname;
                lblEmail.Text = currentAccount.email;
                lblCreatedAt.Text = currentAccount.createdat.ToString();
                lblBalance.Text = currentAccount.balance.ToString();

            }
        }

        private void btnTransaction_Click(object sender, EventArgs e)
        {
            if (currentAccount != null)
            {
                frmTransaction frm = new frmTransaction(currentAccount.AccountId);
                frm.ShowDialog();
            }
        }

        private void AllTransactions_Click(object sender, EventArgs e)
        {
            if (currentAccount != null)
            {
                frmAllTransactions frm = new frmAllTransactions(currentAccount.AccountId);
                frm.ShowDialog();
            }
        }

        private void btnAllWithdrawsDeposits_Click(object sender, EventArgs e)
        {
            if (currentAccount != null)
            {

                frmAllDepostsWithdraws frm = new frmAllDepostsWithdraws(currentAccount.AccountId);
                frm.ShowDialog();
            }
        }

        private void btnDeleteAccount_Click(object sender, EventArgs e)
        {
            if (currentAccount != null)
            {

                if (MessageBox.Show($"Are you sure you want to delete account with ID:{currentAccount.AccountId}", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    if (Accounts_BL.DeleteAccount(currentAccount.AccountId))
                    {
                        MessageBox.Show("Account Deleted Succefully", $"Delete Account {currentAccount.AccountId}", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                        return;
                    }
                    MessageBox.Show("System Error ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnUpdateAccount_Click(object sender, EventArgs e)
        {
            if (currentAccount != null)
            {
                frmUpdate frm = new frmUpdate(currentAccount.AccountId);
                frm.ShowDialog();
            }
        }

        private void lblBalance_Click(object sender, EventArgs e)
        {

        }
    }
}
