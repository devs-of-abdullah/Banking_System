

namespace WinForms_SystemLayer.clsUtil
{
    public partial class ctrlBtnClose : UserControl
    {
        public ctrlBtnClose()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Form? ParentForm = this.FindForm();
            if (ParentForm != null)
            {
                ParentForm.Close();
            }
        }
    }
}
