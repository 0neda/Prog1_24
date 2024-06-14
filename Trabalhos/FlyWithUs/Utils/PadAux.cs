using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlyWithUs.Utils
{
    public static class PadAux
    {
        public static string PadBoth(this string str, int length, char padchar = ' ')
        {
            int spaces = length - str.Length;
            int padLeft = spaces / 2 + str.Length;
            return str.PadLeft(padLeft, padchar).PadRight(length, padchar);
        }

        public static string PadBothMenu(this string str, int length, char padchar = ' ')
        {
            int spaces = length - str.Length;
            int padLeft = spaces / 2 + str.Length;
            return "= "+str.PadLeft(padLeft-2, padchar).PadRight(length-4, padchar)+" =";
        }

        public static string PadRightSpacing(this string str, int length, int spacing, char padchar = ' ')
        {
            int spaces = length - str.Length;
            int padLeft = spaces / 2 + str.Length;
            string strSpacing = string.Empty;
            for (int i = 0; i < spacing; i++)
                strSpacing += " ";
            
            str = strSpacing + str;
            
            return str.PadRight(length, padchar);
        }

        public static string PadRightSpacingMenu(this string str, int length, int spacing, char padchar = ' ')
        {
            int spaces = length - str.Length;
            int padLeft = spaces / 2 + str.Length;
            string strSpacing = string.Empty;
            for (int i = 0; i < spacing; i++)
                strSpacing += " ";
            
            str = strSpacing + str;
            
            return "= " + str.PadRight(length-4, padchar) + " =";
        }
    }
}