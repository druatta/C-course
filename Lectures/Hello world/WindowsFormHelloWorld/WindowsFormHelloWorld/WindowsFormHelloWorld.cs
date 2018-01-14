using System;
using System.Windows.Forms;

namespace WindowsFormHelloWorld
{
    static class WindowsFormHelloWorld
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new GUI());
        }
    }
}
