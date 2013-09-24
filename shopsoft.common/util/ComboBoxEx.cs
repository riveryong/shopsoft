using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace shopsoft.common.util
{
    public class ComboBoxEx
    {
        public string Value;
        public string Key;

        public ComboBoxEx(string value, string key)
        {
            this.Value = value;
            this.Key = key;
        }

        //重点是override ToString 
        public override string ToString()
        { return Value; }
    }

}
