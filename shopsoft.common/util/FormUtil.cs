using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using shopsoft.common.Model;

namespace shopsoft.common.util
{
    public class FormUtil
    {
        /// <summary>
        /// 将分钟转变成几小时几分钟
        /// </summary>
        /// <param name="minute"></param>
        /// <returns></returns>
        public static HourAndMinute HourToMinute(int minute)
        {
            HourAndMinute hm = new HourAndMinute();

            if (minute <= 0)
            {
                return hm;
            }

            if (minute < 60)
            {
                hm.Hour = 0;
                hm.Minute = minute;
                return hm;
            }

            hm.Hour = minute / 60;
            hm.Minute = minute % 60;

            return hm; 
        }

        /// <summary>
        /// 将几小时几分钟转变成分钟
        /// </summary>
        /// <param name="hm"></param>
        public static int MinuteToHour(HourAndMinute hm)
        {
            int minute = 0;
            if (hm.Hour <= 0 && hm.Minute <= 0) 
            {
                return minute;
            }

            minute = hm.Hour * 60 + hm.Minute;

            return minute;

        }

        /// <summary>
        /// 检查手机号是否正确
        /// </summary>
        public static bool CheckPhone(string mobile)
        {
            Regex regex = new Regex("^[1]+[3,4,5,8]+\\d{9}");
            if (!string.IsNullOrEmpty(mobile))
            {
                if (!regex.IsMatch(mobile))
                {
                    return false;
                }
            }

            //if (!string.IsNullOrEmpty(this.txtPhone.Text) && !ValidateUtil.IsDigit(mobile))
            //{
            //    ShowWarnMsgBox("固定电话必须为数字。");
            //    this.txtPhone.Focus();
            //    return false;
            //}
            return true;
        }

        /// <summary>
        /// 检查字符是否半角英文
        /// </summary>
        /// <param name="c">対象文字</param>
        /// <return>true:半角英字, false:其它</return>
        public static bool IsAlphabet(char c)
        {
            return (c >= 0x0041 && c <= 0x005A) || (c >= 0x061 && c <= 0x007A);
        }

        /// <summary>
        /// 检查字符串是否半角英文字母
        /// </summary>
        /// <param name="s">対象文字列</param>
        /// <return>true:半角英字 OR 空串, false:不是</return>
        public static bool IsAlphabet(string s)
        {
            if (!string.IsNullOrEmpty(s))
            {
                foreach (char c in s)
                {
                    if (!IsAlphabet(c))
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        /// <summary>
        /// 检查半角数字
        /// </summary>
        /// <param name="c">対象文字</param>
        /// <return>true:半角数字, false:左記以外</return>
        public static bool IsDigit(char c)
        {
            return (c >= 0x0030 && c <= 0x0039);
        }

        /// <summary>
        /// 判断是否为电话
        /// </summary>
        /// <param name="c">対象文字</param>
        /// <return>true:半角数字, false:左記以外</return>
        public static bool IsPhone(string strPhoneNum)
        {
            if (!string.IsNullOrEmpty(strPhoneNum))
            {
                foreach (char c in strPhoneNum)
                {
                    if (!IsDigit(c) && c != '*' && c != '#')
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        /// <summary>
        /// 检查是否半角数字
        /// </summary>
        /// <param name="s">対象文字列</param>
        /// <return>true:半角数字 or 未输入, false:其他</return>
        public static bool IsDigit(string s)
        {

            if (!string.IsNullOrEmpty(s))
            {
                foreach (char c in s)
                {
                    if (!IsDigit(c))
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        /// <summary>
        /// 检查是否半角英数字
        /// </summary>
        /// <param name="c"></param>
        /// <return>true:是半角英数字, false:不是</return>
        public static bool IsAlphabetDigit(char c)
        {
            return (IsAlphabet(c) || IsDigit(c));
        }


        /// <summary>
        /// 检查是否半角英、数字
        /// </summary>
        /// <param name="s"></param>
        /// <return>true:半角英数字 or 未输入, false:其他</return>
        public static bool IsAlphabetDigit(string s)
        {

            if (!string.IsNullOrEmpty(s))
            {

                foreach (char c in s)
                {
                    if (!IsAlphabetDigit(c))
                    {
                        return false;
                    }
                }
            }

            return true;
        }


        /// <summary>
        /// 整数文字
        /// </summary>
        /// <param name="s"></param>
        /// <param name="hasPlusSign"></param>
        /// <return>true:整数文字列 or 输入, false:左記以外</return>
        public static bool IsNumber(string s, bool hasPlusSign)
        {
            return !IsEmpty(s) ? IsDigit(RemoveSign(s, hasPlusSign)) : true;
        }

        /// <summary>
        /// 删除字符串前的符号
        /// </summary>
        /// <param name="s">対象文字列</param>
        /// <param name="hasPlusSing">プラス符号有無</param>
        /// <returns></returns>
        public static string RemoveSign(string s, bool hasPlusSing)
        {
            if (IsEmpty(s))
            {
                return s;
            }
            return ((hasPlusSing && (s.Length > 1 && (s.IndexOf('-') == 0 || s.IndexOf('+') == 0))) || (s.Length > 1 && s.IndexOf('-') == 0)) ? s.Substring(1) : s;
        }

        /// <summary>
        /// 判断字符串是空或null
        /// </summary>
        /// <param name="s"></param>
        /// <return>true:null or 空串, false:不为空</return>
        public static bool IsEmpty(string s)
        {
            return (s == null || String.Equals(String.Empty, s));
        }

        /// <summary>
        /// 检查小数
        /// </summary>
        /// <param name="s"></param>
        /// <param name="hasPlusSign">是否有符号</param>
        /// <return>true:小数文字列 or 未入力, false:</return>
        public static bool IsDecimal(string s, bool hasPlusSign)
        {
            if (!string.IsNullOrEmpty(s))
            {
                foreach (string _s in RemoveSign(s, hasPlusSign).Split('.'))
                {
                    if (!IsDigit(_s))
                    {
                        return false;
                    }
                }
            }

            return true;
        }
        
    }
}
