using System;
using System.Windows.Forms;

namespace Library_Presentation
{
    public static class ErrorMessageBox
    {
        public static void Show(Exception ex) 
        {
            MessageBox.Show(ex.Message.ToString());
        }
    }
}
