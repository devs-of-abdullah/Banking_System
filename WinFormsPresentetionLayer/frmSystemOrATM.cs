using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinForms_SystemLayer.ATM;
using WinFormsPresentetionLayer;

namespace WinForms_SystemLayer
{
    public partial class frmSystemOrATM : Form
    {
        public frmSystemOrATM()
        {
            InitializeComponent();
        }

        private void frmSystemOrATM_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.None;
            lblAllBalanceAtSystem.Text = BussinessLayer.Global_BL.TotalBalanceAtSystem(true).ToString();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAtm_Click(object sender, EventArgs e)
        {
            frmAtmMain frm = new frmAtmMain();
            frm.ShowDialog();
        }

        private void btnSystem_Click(object sender, EventArgs e)
        {
            frmLogin frm = new frmLogin();
            frm.ShowDialog();

        }
    }
}
