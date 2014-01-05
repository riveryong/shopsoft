using System;
using System.Collections.Generic;
using System.Linq;
using System.Configuration;

namespace shopsoft.common.util
{
    public class ConfigFileUtil
    {

        #region 操作AppSettings
        /// <summary>        
        /// 清空        
        /// </summary>          
        public static void clear()
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.AppSettings.Settings.Clear();
            config.Save();
        }
        
        /// <summary>
        /// 根据key取得AppSettings的value
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public static String getAppSettinsValueByKey(string key)
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

            if (config.AppSettings.Settings[key] != null)
            {
                return config.AppSettings.Settings[key].Value;
            }
            else
            { return null; }
        }

        /// <summary>
        /// 创建 和 更新AppSetting 
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        public static void updateAppSettingsValue(string key, string value)
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

            //不存在就创建
            if (config.AppSettings.Settings[key] == null)
            {
                config.AppSettings.Settings.Add(key, value);
            }
            //存在就更新
            else
            {

                config.AppSettings.Settings[key].Value = value;
            }

            config.Save();

        }
        #endregion


        #region 操作ConnectionString
        /// <summary>
        /// 根据key获得ConnectionString的value
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public static string getConnectionValueByKey(string key)
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

            if (config.ConnectionStrings != null)
            {
                return config.ConnectionStrings.ConnectionStrings[key].ConnectionString;
            }
            else
            { return null; }

        }

        /// <summary>
        /// 更新ConnectionString(如果存在就更新) 
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        public static Boolean updateConnectionValue(string conName, string conStr, string providerName)
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

            if (string.IsNullOrEmpty(conName) && string.IsNullOrEmpty(conStr) && string.IsNullOrEmpty(providerName))
            {
                return false;
            }
            //不存在就创建
            if (config.ConnectionStrings.ConnectionStrings[conName] == null)
            {
                ConnectionStringSettings settings = new ConnectionStringSettings(conName, conStr, providerName);
                config.ConnectionStrings.ConnectionStrings.Add(settings);
            }
            //存在就更新
            else
            {
                config.ConnectionStrings.ConnectionStrings[conName].ConnectionString = conStr;
                config.ConnectionStrings.ConnectionStrings[conName].ProviderName = providerName;
            }

            config.Save(ConfigurationSaveMode.Modified);
            return true;

        }

        ///<summary> 
        ///创建ConnectionString(如果存在，先删除再创建) 
        ///</summary> 
        ///<param name="config">Configuration实例</param>
        ///<param name="newName">连接字符串名称</param> 
        ///<param name="newConString">连接字符串内容</param> 
        ///<param name="newProviderName">数据提供程序名称</param>         
        public static Boolean CreateConnectionStringsConfig(Configuration config, string newName, string newConString, string newProviderName)
        {
            if (config == null && string.IsNullOrEmpty(newName) && string.IsNullOrEmpty(newConString) && string.IsNullOrEmpty(newProviderName))
            {
                return false;
            }

            bool isModified = false;
            //记录该连接串是否已经存在      
            //如果要更改的连接串已经存在      
            if (config.ConnectionStrings.ConnectionStrings[newName] != null)
            { isModified = true; }

            //新建一个连接字符串实例      
            ConnectionStringSettings mySettings = new ConnectionStringSettings(newName, newConString, newProviderName);

            // 如果连接串已存在，首先删除它      
            if (isModified)
            {
                config.ConnectionStrings.ConnectionStrings.Remove(newName);
            }
            // 将新的连接串添加到配置文件中.      
            config.ConnectionStrings.ConnectionStrings.Add(mySettings);
            // 保存对配置文件所作的更改      
            config.Save(ConfigurationSaveMode.Modified);

            return true;
        }

        #endregion


    }
}