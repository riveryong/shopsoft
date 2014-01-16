using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.Xpo;
using DevExpress.Xpo.DB;
using System.Windows.Forms;
using shopsoft.common;
using Microsoft.Practices.EnterpriseLibrary.Data;
using System.Configuration;
using shopsoft.common.util;

namespace shopsoft.common.DB
{
    public class DBHelper
    {
        public static void setDBSession()
        {
            #region 连接数据库
            string conn = DevExpress.Xpo.DB.AccessConnectionProvider.GetConnectionString(Application.StartupPath + SysParam.DBName,SysParam.DBUid,SysParam.DBPwd);

            XpoDefault.DataLayer = XpoDefault.GetDataLayer(conn, AutoCreateOption.DatabaseAndSchema);
            #endregion

            #region 连接数据库的另一种方法
            /*
             * // If the default session is connected, disconnect it.
            if (Session.DefaultSession.IsConnected)
            {
                Session.DefaultSession.Disconnect();
            }

            // Retrieve the MS Access database-specific connection string.
            Session.DefaultSession.ConnectionString =
            AccessConnectionProvider.GetConnectionString(Application.StartupPath + "\\Database\\shopManage.mdb");
            // The default data access layer is created and connected to the database 
            // using the retrieved connection string.
            Session.DefaultSession.Connect();*/
            #endregion


        }

        #region 通过MicrosoftEnterpriseLibrary获得数据库连接
        public static Database getDataBase()
        {
            return getDataBase(null);
        }

        public static Database getDataBase(String conKey)
        {
            if(string.IsNullOrEmpty(conKey))
            {
                conKey = "sopsoftConnectionString";
            }

            string conStr = ConfigurationManager.ConnectionStrings[conKey].ConnectionString;
            string providerStr = ConfigurationManager.ConnectionStrings[conKey].ProviderName;
            conStr = conStr.Replace("|DataDirectory|", Application.StartupPath);
            ConfigFileUtil.updateConnectionValue(conKey, conStr, providerStr);

            Database db = DatabaseFactory.CreateDatabase();
            return DatabaseFactory.CreateDatabase(conKey);
            
        }
        #endregion

    }
}
