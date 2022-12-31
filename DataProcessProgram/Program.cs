using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataProcessProgram
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            SplasherForm.Show(typeof(Splasher));
            Application.ThreadException += new System.Threading.ThreadExceptionEventHandler(Application_ThreadException);
            Application.Run(new FrmMain());
        }
        private static void Application_ThreadException(object sender, System.Threading.ThreadExceptionEventArgs ex)
        {

            string message = string.Format("操作发生错误，您需要退出系统么？\r\n{0}", ex.Exception.StackTrace);
            if (DialogResult.Yes == MessageBox.Show(message, "系统错误", MessageBoxButtons.YesNo))
            {
                Application.Exit();
            }
        }
    }
}
