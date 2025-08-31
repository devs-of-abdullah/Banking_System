
using BussinessLayer;
using System.Security.Principal;

namespace WinForms_SystemLayer
{
    public partial class frmDeposit : Form
    {
        int CurrentId;
        public frmDeposit(int ID)
        {
            InitializeComponent();
            CurrentId = ID;
        }

        private void frmDeposit_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.None;

        }
        bool validateAmount()
        {
            if (decimal.TryParse(txtAmount.Text, out decimal amount )) {
                if (amount > 0) { 
                
                    return true;
                }
               
            } return false;
        }
        private void btnDeposit_Click(object sender, EventArgs e)
        {
            Accounts_BL? Account = Accounts_BL.GetAccountInfo(CurrentId);
            decimal amount = Convert.ToDecimal(txtAmount.Text);

            if (validateAmount() && Account != null)
            {

                if (Transactions_BL.DepositByATM(CurrentId, amount))

                    MessageBox.Show($"{Account.fullname} you have deposited: {amount} \n your new balance is: {Account.balance + amount}", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);

       
               
            } else
                    MessageBox.Show("Please  Enter a valid Amount", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
           
           return;
            
               
        }
    }
}
