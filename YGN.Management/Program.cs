using Commons.Enums;
using DevExpress.LookAndFeel;
using DevExpress.Skins;
using DevExpress.UserSkins;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;
using YGN.DataAccesLayer.Concrete;
using YGN.Management.Config;

namespace YGN.Management
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            BonusSkins.Register();

            GlobalVariables.AppPath = Application.StartupPath;
            //Database.SetInitializer<YGNContext>(null); 

            Database.SetInitializer<YGNContext>(new CreateDatabaseIfNotExists<YGNContext>());


            //if (!new ConfigManager().ReadConnectionSettings())
            //{
            //    return;
            //}
            Application.Run(new MainView());

          
        }
    }
}
