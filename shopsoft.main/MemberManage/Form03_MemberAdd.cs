using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using shopsoft.main.Base;
using DevExpress.Xpo;
using shopsoft.common.DB;

namespace shopsoft.main.MemberManage
{
    public partial class Form03_MemberAdd : BaseFormX
    {
        public Form03_MemberAdd()
        {
            InitializeComponent();
        }

        private void btnCreateMember_Click(object sender, EventArgs e)
        {
            
            t_Member_Info memberInfo = new t_Member_Info(this.DBSession);

            memberInfo.Member_Name = this.txtMemberName.Text;
            memberInfo.Member_No = this.txtMemberNo.Text;

            memberInfo.Save();
            if (memberInfo.Member_ID != 0)
            {
                ShowInfoMsgBox("新建会员成功！");
            }
            else
            {
                ShowWarnMsgBox("新建会员失败！");
            }

        }
    }
}
