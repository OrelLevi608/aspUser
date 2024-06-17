using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ecommerce //.App_Code
{
    public class GlobFunc
    {
        // פונקציה המקבלת מספר ומחזירה מחרוזת המוכבת תווים אקראיים באורך שקיבלנו
        public static string GetRandStr(int length)
        {
            // אם אני לוקח 
            string str = "abcdefghijklmnopqurstuvwxyz0123456789"; // 36 תווים
            string RetStr = "";
            Random rnd = new Random();
            int index;
            for (int i = 0; i < length; i++)
            {
               index = rnd.Next(str.Length);
               RetStr += str[index];
            }

            return RetStr;


        }
    }
}