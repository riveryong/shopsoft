using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace shopsoft.common.util
{
    public class BusinessUtil
    {
        /// <summary>
        /// 判断form是否打开
        /// </summary>
        /// <param name="formName">form名</param>
        /// <returns></returns>
        public static Form checkFormIsOpened(string formName)
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
    }
}
