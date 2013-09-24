using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Xml;
using shopsoft.common.DB;

namespace shopsoft.common
{
    public class SysParam
    {

        public static string DBName = string.Empty;
        public static string DBUid = string.Empty;
        public static string DBPwd = string.Empty;
        /// <summary>
        /// 构造函数
        /// </summary>
        static SysParam()
        {
            // DB名
            DBName = ConfigurationManager.AppSettings ["DB.Name"];
            DBUid = ConfigurationManager.AppSettings["DB.Server.UserId"];
            DBPwd = ConfigurationManager.AppSettings["DB.Server.Password"];
        }

        // 操作者
        public static string OperatorNo = string.Empty;
        public static string OperatorPWD = string.Empty;
        public static int OperatorType = 0;

        // 企业信息
        public static t_Company_Info companyInfo = null;

        // 店铺信息
        public static t_Store_Info storeInfo = null;

        // 生日年月日数据
        public static XmlDocument xmlYearInfo = new XmlDocument();
        public static XmlDocument xmlMonthInfo = new XmlDocument();
        public static XmlDocument xmlDayInfo = new XmlDocument();

        
    }
}
 