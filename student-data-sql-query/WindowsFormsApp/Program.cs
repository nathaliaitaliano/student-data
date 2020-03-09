using System;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new formStudent());
            log4net.Config.XmlConfigurator.Configure();
        }
    }
}
