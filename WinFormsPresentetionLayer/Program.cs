using WinForms_SystemLayer;

namespace WinFormsPresentetionLayer
{
    internal static class Program
    {
     
        [STAThread]
        static void Main()
        {
         
            ApplicationConfiguration.Initialize();
            Application.Run(new frmSystemOrATM());
        }
    }
}