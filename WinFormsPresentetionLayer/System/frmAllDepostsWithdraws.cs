using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms_SystemLayer
{
    public partial class frmAllDepostsWithdraws : Form
    {
        int CurrentID;
        public frmAllDepostsWithdraws(int id)
        {
            CurrentID = id;
            InitializeComponent();

        }

        private void frmAllDepostsWithdraws_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.None;
            DataTable dtAllDeposits = BussinessLayer.Transactions_BL.GetAllDeposits(CurrentID);
            DataTable dtAllWithdraws = BussinessLayer.Transactions_BL.GetAllWithdraws(CurrentID);



            dgvDeposits.DataSource = dtAllDeposits;
            dgvWithdraws.DataSource = dtAllWithdraws;
        }
    }
}
