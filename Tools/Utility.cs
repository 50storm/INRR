using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.VisualBasic;
using System.Text.RegularExpressions;


namespace Jisseki_Report_Ibaraki.Tools
{
    public class Utility
    {

        /// <summary>
        /// Covert JapaneseYear to ChristianYear
        /// </summary>
        /// <param name="strYY">JapaneseEra(Wareki)</param>
        /// <returns>ChristianEra</returns>
        public static string HeiseiToChristianEra(String strYY) {
            int iYY;
            if (strYY == string.Empty)
            {
                iYY = 0;
            }
            else
            {
                iYY = int.Parse(strYY);
            }
            return (iYY + 1988).ToString();
 
        }
        /// <summary>
        /// Get JapaneseEraLetter
        /// </summary>
        /// <param name="iEra">0to4</param>
        /// <returns>JapaneseEraLetter</returns>
        public static string getJapaneseEra(int iEra){
            string strEra=string.Empty;
            switch (iEra)
            {
                case 4://平成
                    strEra = "平成";
                    break;
                    
                case 3://昭和
                    strEra = "昭和";
                    break;

                case 2://大正
                    strEra = "大正";
                    break;

                case 1://明治
                    strEra = "明治";
                    break;
            
            }

            return strEra;
        }

        /// <summary>
        /// convert 0 to space
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        public static string zeroToSpace(string param){
            if (param == "0")
            {
                return string.Empty;
            }
            else 
            {
                return param;
            }
        }

        /// <summary>
        /// 全角→半角
        /// </summary>
        /// <param name="_Zenkaku"></param>
        public static string ToHankaku(string _Zenkaku) {
            return Strings.StrConv(_Zenkaku, VbStrConv.Narrow);       
        }

        public static bool Number3IsValid(string chkValue)   {
            Regex reg = new Regex("[0-9]{1,3}");
            if (reg.IsMatch(chkValue))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool IsNotNumber(string chkValue)
        {
            Regex reg = new Regex(@"\D");//数字以外はだめ
            if (reg.IsMatch(chkValue))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool IsUID(string UID) 
        {
            Regex reg = new Regex(@"[0-9][0-9][0-9]-[0-9][0-9][0-9][0-9]+$");
            if (reg.IsMatch(UID))
            {
                return true;
            }
            else
            {
                return false;
            }
        } 


        public static string covertDigit2(int val)
        {

            if (val == 1 || val == 2  || val == 3 ||
                val == 4 || val == 5  || val == 6 ||
                val == 7 || val == 9  || val == 9
                ){
            
                return ("0" + val.ToString()).ToString();
            }
            return val.ToString();       
        }

    }
}