using System;
using System.Collections.Generic;
using DevExpress.XtraEditors;
using DevExpress.LookAndFeel;
using System.Windows.Forms;
using DevExpress.Xpo;

namespace shopsoft.main.Base
{
    public partial class BaseForm : XtraForm
    {
        public readonly Session DBSession = Session.DefaultSession;

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

        public BaseForm()
        {
            InitializeComponent();

            // 所有的窗口都继承自BaseForm,该窗口UseDefaultLookAndFeel 属性为false
            // 方式以下两种设置达到的效果是将所有子类窗口的皮肤统一设置
            // 第一种方法 可行
            //UserLookAndFeel.Default.SetSkinStyle("Money Twins");
            
            // 第二种方法 如果使用该方法设置，会导致mainForm的LookAndFeel.UserDefaultLookAndFeel的属性为true
            // 并且mainForm.Ribbon的样式不变。
            //this.LookAndFeel.SetSkinStyle("Office 2010 Blue");
        }

        /// <summary>
        /// 判断form是否打开
        /// </summary>
        /// <param name="formName">form名</param>
        /// <returns></returns>
        protected static Form checkFormIsOpened(string formName)
        {
            foreach (Form frm in Application.OpenForms)
            {
                if (frm.Name == formName)
                {
                    return frm;
                }
            }

            return null;
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
