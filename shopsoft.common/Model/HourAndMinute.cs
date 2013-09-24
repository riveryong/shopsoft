using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace shopsoft.common.Model
{
    public class HourAndMinute
    {
        public int Hour { get; set; }

        public int Minute { get; set; }

        public HourAndMinute()
        {
            this.Hour = 0;
            this.Minute = 0;
        }

        public override string ToString()
        {
            string res = string.Empty;

            if(this.Hour != 0)
            {
                res = Hour.ToString() + "小时";

            }

            if (Minute != 0)
            {
                res = res + Minute.ToString() + "分";
            }

            return res;
 
        }
        
    }
}
