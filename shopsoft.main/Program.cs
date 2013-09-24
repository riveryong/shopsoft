using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DevExpress.Skins;
using DevExpress.LookAndFeel;
using shopsoft.common.DB;


namespace shopsoft.main
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            // 装载皮肤
            DevExpress.UserSkins.OfficeSkins.Register();
            DevExpress.UserSkins.BonusSkins.Register();
            DevExpress.Skins.SkinManager.EnableFormSkins();

            // 激活标题栏换肤功能
            SkinManager.EnableFormSkins();
            LookAndFeelHelper.ForceDefaultLookAndFeelChanged();
            UserLookAndFeel.Default.SetSkinStyle("Money Twins");

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            DBHelper.setDBSession();

            //Application.Run(new Form1());

            Form02_Login lgnFrm = new Form02_Login();

            if (lgnFrm.ShowDialog() == DialogResult.OK)
            {
                // Application.Run(new Form1());//打开你指定的窗口 
                Application.Run(new Form01_mainForm());
            }
            else if (lgnFrm.ShowDialog() == DialogResult.Cancel)
            {
                Application.Exit();
            }
            
        }
    }
}
