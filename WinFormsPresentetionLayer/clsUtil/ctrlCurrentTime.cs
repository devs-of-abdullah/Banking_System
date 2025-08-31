using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms_SystemLayer.clsUtil
{
    public partial class ctrlCurrentTime : UserControl
    {
        public ctrlCurrentTime()
        {
            InitializeComponent();
        }

        private void ctrlCurrentTime_Load(object sender, EventArgs e)
        {
            txtCurrentTime.Text = DateTime.Now.ToString();
        }

        private void txtCurrentTime_TextChanged(object sender, EventArgs e)
        {
            txtCurrentTime.Text = DateTime.Now.ToString();

        }
    }
}
