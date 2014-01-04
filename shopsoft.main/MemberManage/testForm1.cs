using System;
using System.Collections.Generic;
using System.Windows.Forms;
using shopsoft.main.Base;
using Microsoft.Practices.EnterpriseLibrary.Data;
using System.Configuration;
using System.Data.Common;
using System.Data;

namespace shopsoft.main.MemberManage
{
    public partial class testForm1 : BaseFormX
    {
        public testForm1()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            DateTime dt = ((DateTime)this.dateEdit1.EditValue).AddDays(0.99);
            this.textEdit1.Text = dt.ToString();
            string conStr = ConfigurationManager.ConnectionStrings["sopsoftConnectionString"].ConnectionString;
            MessageBox.Show(conStr);
            Database db = DatabaseFactory.CreateDatabase();
            String sqlStr = "select * from MemberGrade;";
            DbCommand cmd = db.GetSqlStringCommand(sqlStr);
            DataSet ds = db.ExecuteDataSet(cmd);
            gridControl1.DataSource = ds.Tables[0];
        }


        private void dropDownButton1_Click(object sender, EventArgs e)
        {
            popupControlContainer1.Show();
        }

        private void comboBoxEdit1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
