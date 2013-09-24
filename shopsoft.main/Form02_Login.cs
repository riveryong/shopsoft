using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using shopsoft.main.Base;
using shopsoft.common;
using shopsoft.common.Const;


namespace shopsoft.main
{
    public partial class Form02_Login : BaseForm
    {

        public Form02_Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // 登入成功，关闭登入窗口 
            this.DialogResult = DialogResult.OK;
            SysParam.OperatorNo = "admin";
            SysParam.OperatorPWD = "1";
            SysParam.OperatorType = Role.Manager;
            this.Close();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            // 登入成功，关闭登入窗口 
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
