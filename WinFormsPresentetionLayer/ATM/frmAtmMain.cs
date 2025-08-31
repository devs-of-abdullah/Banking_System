

using BussinessLayer;

namespace WinForms_SystemLayer.ATM
{
    public partial class frmAtmMain : Form
    {

        public frmAtmMain()
        {
            InitializeComponent();
            ctrlpin1.PINSubmitted += Ctrlpin1_PINSubmitted;

        }

        private void frmAtmMain_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.None;

        }
        private void Ctrlpin1_PINSubmitted(object sender, string pin)
        {
            lblPin.Text = pin; 
            
        }

        int _CheckEntry()
        {
            string ID = txtID.Text;
            string Pin = lblPin.Text;

            if (int.TryParse(ID, out int intID))
            {
                if (Accounts_BL.AtmLogin(intID, Pin))
                {
                    MessageBox.Show("Welcome, to the system", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return intID;
                }
                return -1;
            }
            MessageBox.Show("ID Must be a number", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return -1;
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {

            int ID = _CheckEntry();
            if(ID != -1)
            {
                frmInAtm frm = new frmInAtm(ID);
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("InCooreect");
            }

        }
    }
}
