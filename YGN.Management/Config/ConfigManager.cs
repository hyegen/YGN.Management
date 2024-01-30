using Commons;
using Commons.Enums;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YGN.Management.Properties;
using System.Configuration;
using YGN.DataAccesLayer.Concrete;
using System.Reflection;
using YGN.BusinessLayer.ConfigManager;

namespace YGN.Management.Config
{
    public class ConfigManager
    {
        private ConfigForm configForm;
        private ConnectionInfo connectionInfo;
        private static readonly string CONFIGFILENAME = "YGNManagement.config";
        private static readonly string connInfoTemplate = "{0}|{1}|{2}|{3}";

        public bool ReadConnectionSettings()
        {
            setConfigFile();
            createConfigFileIfNotExists();

            connectionInfo = new ConnectionInfo();
            if (ConfigurationManager.AppSettings.HasKeys() && ConfigurationManager.AppSettings.AllKeys.Any(p => p == "ConnectionSettings"))
            {
                try
                {
                    //var connectionInfos = EncDec.Decrypt(ConfigurationManager.AppSettings["ConnectionSettings"].ToString());
                    var connectionInfos = ConfigurationManager.AppSettings["ConnectionSettings"].ToString();
                    string[] appSettings = connectionInfos == null ? new string[0] : connectionInfos.Split('|');
                    if (appSettings.Length == 4)
                    {
                        connectionInfo = new ConnectionInfo
                        {
                            ServerName = appSettings[0],
                            UserName = appSettings[1],
                            Password = appSettings[2],
                            DatabaseName = appSettings[3]
                        };

                        if (test.TryConnection(connectionInfo.ConnectionString))
                        {
                            GlobalVariables.ConnectionInfo = connectionInfo;
                            return true;//controlVersion();
                        }
                    }
                    else
                    {
                        XtraMessageBox.Show(string.Format("Logo ile bağlantı kurulamıyor.{0}{0}Lütfen veritabanı ayarlarını kontrol ediniz.", Environment.NewLine));
                    }
                }
                catch
                {
                    XtraMessageBox.Show(string.Format("Logo ile bağlantı kurulamıyor.{0}{0}Lütfen veritabanı ayarlarını kontrol ediniz.", Environment.NewLine));
                }
            }

            configForm = new ConfigForm();
            configForm.TryConnection += configForm_TryConnection;
            configForm.SaveAndNext += configForm_SaveAndNext;
            configForm.DataSource = connectionInfo;
            if (configForm.ShowDialog() == DialogResult.OK)
            {
                return true;//controlVersion();
            }
            return false;
        }

        private static bool createConfigFileIfNotExists()
        {
            var configFile = Path.Combine(GlobalVariables.AppPath, CONFIGFILENAME);
            if (!File.Exists(configFile))
            {
                try
                {
                    File.WriteAllText(configFile, Resources.YGN_ManagementConfiguration2);
                    XtraMessageBox.Show("Configuration dosyası başarıyla oluşturuldu.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    XtraMessageBox.Show("Configuration dosyası oluşturulurken hatayla karşılaşıldı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            return true;
        }

        private static void setConfigFile()
        {
            AppDomain.CurrentDomain.SetData("APP_CONFIG_FILE", Path.Combine(Application.StartupPath, CONFIGFILENAME));

            typeof(ConfigurationManager)
                .GetField("s_initState", BindingFlags.NonPublic | BindingFlags.Static)
                .SetValue(null, 0);

            typeof(ConfigurationManager)
                .GetField("s_configSystem", BindingFlags.NonPublic | BindingFlags.Static)
                .SetValue(null, null);

            typeof(ConfigurationManager)
                .Assembly.GetTypes()
                .Where(x => x.FullName == "System.Configuration.ClientConfigPaths")
                .First()
                .GetField("s_current", BindingFlags.NonPublic | BindingFlags.Static)
                .SetValue(null, null);
        }

        private bool validate()
        {
            configForm.Validate();
            var sb = new StringBuilder();
            if (string.IsNullOrEmpty(connectionInfo.ServerName))
            {
                sb.AppendLine("Sunucu girilmelidir");
            }
            if (string.IsNullOrEmpty(connectionInfo.UserName))
            {
                sb.AppendLine("Kullanıcı adı girilmelidir");
            }
            if (string.IsNullOrEmpty(connectionInfo.DatabaseName))
            {
                sb.AppendLine("Veritabanı adı girilmelidir");
            }
            if (sb.Length > 0)
            {
                XtraMessageBox.Show(string.Format("Lütfen bilgileri kontrol edip tekrar deneyiniz.{0}{0}{1}", Environment.NewLine, sb.ToString()));
                return false;
            }
            return true;
        }

        private bool createDatabase()
        {
            try
            {
                return CreateDatabaseManager.CreateDatabase();
            }
            catch
            {
                return false;
            }
        }

        private void configForm_TryConnection()
        {
            if (!validate())
                return;
            var d = test.TryConnection(connectionInfo.ConnectionString);
            var result = test.TryConnection(connectionInfo.ConnectionString)
               ? XtraMessageBox.Show(string.Format("Bağlantı Başarılı", Environment.NewLine))
               : XtraMessageBox.Show(string.Format("Bağlantı kurulamıyor.{0}{0}Lütfen veritabanı ayarlarını kontrol ediniz.", Environment.NewLine));
        }

        private void configForm_SaveAndNext()
        {
            if (!validate())
                return;
           
                if (!test.TryConnection(connectionInfo.ConnectionString))
                {
                XtraMessageBox.Show(string.Format("Logo ile bağlantı kurulamıyor.{0}{0}Lütfen veritabanı ayarlarını kontrol ediniz.", Environment.NewLine));
                    return;
                }
                
                try
                {
                    Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                    if (config.AppSettings.Settings.Count > 0 && config.AppSettings.Settings["ConnectionSettings"] != null)
                    {
                        config.AppSettings.Settings["ConnectionSettings"].Value =connectionInfo.ToString();
                    }
                    else
                    {
                        config.AppSettings.Settings.Add("ConnectionSettings", connectionInfo.ToString());
                    }
                    config.Save(ConfigurationSaveMode.Modified);
                    ConfigurationManager.RefreshSection("appSettings");

                    GlobalVariables.ConnectionInfo = connectionInfo;
                    if (!createDatabase())
                    {
                    XtraMessageBox.Show(string.Format("Veritabanı araçları oluşturulamıyor.", Environment.NewLine));
                        return;
                    }
                    configForm.DialogResult = DialogResult.OK;
                }
                catch
                {
                XtraMessageBox.Show(string.Format("Bağlantı ayarları kaydedilemedi.", Environment.NewLine));
                    configForm.DialogResult = DialogResult.Cancel;
                }
            
        }

    }
}
