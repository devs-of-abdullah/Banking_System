using BussinessLayer;


namespace WinForms_SystemLayer.ATM
{
    public partial class frmWithdraw : Form
    {
       
        
        int CurrentID;
        public frmWithdraw(int ID)
        {
            
             InitializeComponent();
            CurrentID = ID;
        }

        private void frmWithdraw_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.None;
          
          

        }
        bool validateAmount()
        {
            if (decimal.TryParse(txtAmount.Text, out decimal Amount))
            {
                if (Amount > 0) { return true; }
                return false;
            }
            return false;
        }
            


                private void btnWithdraw_Click(object sender, EventArgs e)
                {
                    Accounts_BL? Account = Accounts_BL.GetAccountInfo(CurrentID);
                    decimal amount = Convert.ToDecimal(txtAmount.Text);

                    if(validateAmount() && Account != null)
                    {
                       
                        
                            if (Transactions_BL.WithdrawByATM(CurrentID, amount))
                                MessageBox.Show($"{Account.fullname} you have withdrawed: {amount} \n your new balance is: {Account.balance - amount}", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            else
                                MessageBox.Show($"Error while Withdrawing your Balance is {Account.balance} ", "Unsuccefull", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;

                        
                    }
                    else
                    {
                        MessageBox.Show("Enter a valid value", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    return;


                }
    }
}
