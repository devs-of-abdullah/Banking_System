

namespace WinForms_SystemLayer.ATM
{
    public partial class ctrlPIN : UserControl
    {
        public event EventHandler<string> PINSubmitted;


        public ctrlPIN()
        {
            InitializeComponent();
        }
        private void ButtonClick(object sender, EventArgs e)
        {
            if (sender is Button btn)
            {

                if (btn == buttonDelete)
                {
                    if (lblPin.Text.Length > 0)
                        lblPin.Text = lblPin.Text.Substring(0, lblPin.Text.Length - 1);

                }
                else if (btn == buttonSend)
                {

                    if (lblPin.Text.Length != 4)
                    {
                        MessageBox.Show("PIN must be 4 numbers",
                                        "Missing Numbers",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Warning);
                    }
                    else
                    {
                        string pin = lblPin.Text;
                        PINSubmitted?.Invoke(this, pin);

                        lblPin.Text = "";
                    }
                }

                else if (btn.Tag != null)
                {

                    if (lblPin.Text.Length < 4)
                        lblPin.Text += btn.Tag.ToString();
                }
            }
        }

        public string TakePIN()
        {
            return lblPin.Text;
        }

     
    }
}
