using BussinessLayer;

using System.Data;


namespace WinForms_SystemLayer
{
    public partial class frmAllTransactions : Form
    {
        int CurrentID;
        public frmAllTransactions(int ID)
        {
            
            InitializeComponent();
            CurrentID = ID;
        }

        private void frmAllTransactions_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.None;
           


            DataTable dtSentTransactions = Transactions_BL.GetAllTranstactions(CurrentID,true);
                DataTable dtRecievedTransactions = Transactions_BL.GetAllTranstactions(CurrentID,false);
            dgvRecieved.DataSource = dtRecievedTransactions;
            dgvSent.DataSource = dtSentTransactions;
            
        }
    }
}
