using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace STMS
{
    internal static class Program
    {
        /// <summary>
        /// アプリケーションのメイン エントリ ポイントです。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            LoginForm f = new LoginForm();
            if (f.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new FormMain(f.PersonModel));
            }
            else
            {
                Console.WriteLine("登録失敗");
            }
            
        }
    }
}
