using BussinessLayer;
using WinForms_SystemLayer.ATM;


namespace WinForms_SystemLayer
{
    public partial class frmInAtm : Form
    {
        Accounts_BL? CurrentAccount;
     
        int CurrentId;
     
        public frmInAtm(int ID)

        {
            InitializeComponent();
            CurrentAccount = Accounts_BL.GetAccountInfo(ID);

        }
      

        private void frmPerformWithdrawOrDeposit_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.None;
            if (CurrentAccount != null)
            {
                lblID.Text = CurrentAccount.AccountId.ToString();
                lblName.Text = CurrentAccount.fullname;
                lblEmail.Text = CurrentAccount.email;
                lblBalance.Text = CurrentAccount.balance.ToString();
                CurrentId = CurrentAccount.AccountId;
            }

        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            
                frmDeposit frm = new frmDeposit(CurrentId);
                frm.ShowDialog();
            
            
            

            return;
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
           
            
                frmWithdraw frm = new frmWithdraw(CurrentId);
                frm.ShowDialog();
           
            
            
            return;
        }
    }
}
