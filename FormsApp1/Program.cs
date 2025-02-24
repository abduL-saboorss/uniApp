using System;
using System.Windows.Forms;

namespace FormsApp1
{
    static class Program
    {
        // Update the Main method in Program.cs
        [STAThread]

        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm());
        }
    }
}
