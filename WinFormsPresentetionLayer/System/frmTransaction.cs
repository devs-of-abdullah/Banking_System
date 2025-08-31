

using BussinessLayer;
using clsUtil;

namespace WinForms_SystemLayer
{
    public partial class frmTransaction : Form
    {
        int CurrentID;
        Accounts_BL? Accoount;
       

        public frmTransaction(int ID)
        {
            CurrentID = ID;
            InitializeComponent();
        }

        private void frmTransaction_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.None;
            Accoount = Accounts_BL.GetAccountInfo(CurrentID);

        }
        bool Validate()
        {
            if (Accoount != null)
            {
                if (txtRecieverID.Text != "" && txtAmount.Text != "")
                {
                    if (clsValidation.IsNumber(txtRecieverID.Text) && clsValidation.IsNumber(txtAmount.Text))
                    {
                        if (Accoount.balance > Convert.ToInt32(txtAmount.Text))
                        {
                            return true;
                        }
                        MessageBox.Show($"Insufficent balance your current balance is: {Accoount.balance} ", "Insufficent Balance", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }
                    else
                    {
                                        MessageBox.Show("Please Enter Valid values", "Inavalid values", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return false;
                    }


                }
                MessageBox.Show("Reciever Id and amount can nt be empty", "Empty", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                       
                return false ;
               
            }
            return false;
        }
        

        private void btnSend_Click(object sender, EventArgs e)
        {
          

            if (Validate()) { 

              int RecieverID = Convert.ToInt32(txtRecieverID.Text);
            Decimal Amount = Convert.ToDecimal(txtAmount.Text);
            string Description = txtDescription.Text;

                if (MessageBox.Show($"Are You sure you want to transfer to account {RecieverID}", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    if (Transactions_BL.TransferBetweenAccounts(CurrentID, RecieverID, Amount, Description) && Accoount != null)
                    {
                        MessageBox.Show($"Transaction made succefully to account with id {RecieverID}, your current balance is {Accoount.balance - Amount}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show($"Account ID {RecieverID} does not exists ","Error",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                    }
                }
            }
        }
    }
}
