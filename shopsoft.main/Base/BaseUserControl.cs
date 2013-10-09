using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.LookAndFeel;
using DevExpress.XtraEditors;

namespace shopsoft.main.Base
{
    public partial class BaseUserControl : XtraUserControl
    {
        /// <summary>
        /// 消息类型：错误
        /// </summary>
        private const string c_strErrorTitle = "错误";

        /// <summary>
        /// 消息类型：警告
        /// </summary>
        private const string c_strWarnTitle = "确认";

        /// <summary>
        /// 消息类型：提示
        /// </summary>
        private const string c_strInfoTitle = "信息";

        public BaseUserControl()
        {
            InitializeComponent();
            // 设置UserControl的皮肤
            //UserLookAndFeel.Default.SetSkinStyle("Money Twins");
        }

        #region Message框
        /// <summary>
        /// 警告对话框
        /// </summary>
        /// <param name="strMsgText">警告消息</param>
        public static void ShowWarnMsgBox(string strMsgText)
        {
            XtraMessageBox.Show(strMsgText, c_strWarnTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        /// <summary>
        /// 信息对话框
        /// </summary>
        /// <param name="strMsgText">显示消息</param>
        public static void ShowInfoMsgBox(string strMsgText)
        {
            XtraMessageBox.Show(strMsgText, c_strInfoTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// 信息对话框
        /// </summary>
        /// <param name="strMsgText">显示消息</param>
        public static DialogResult ShowInfoMsgBox2Btn(string strMsgText)
        {
            return XtraMessageBox.Show(strMsgText, c_strInfoTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Information);
        }
        #endregion
    }
}
