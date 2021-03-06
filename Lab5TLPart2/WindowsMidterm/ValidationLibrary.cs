﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsMidterm
{
    class ValidationLibrary
    {
        public static bool isEmailValid(string temp)
        {
            bool blnResult = true;

            int atLoc = temp.IndexOf("@");
            int NextatLoc = temp.IndexOf("@", atLoc + 1);

            int periodloc = temp.LastIndexOf(".");

            if (temp.Length < 8)
            {
                blnResult = false;
            }
            else if (atLoc < 2)
            {
                blnResult = false;
            }
            else if (periodloc + 2 > (temp.Length))
            {
                blnResult = false;
            }
            return blnResult;
        }

        public static bool isZipValid(string temp)
        {
            bool blnResult = true;

            if (temp.Length != 5)
            {
                blnResult = false;
            }

            return blnResult;
        }

        public static bool isPhoneValid(string temp)
        {
            bool blnResult = true;

            if (temp.Length != 10)
            {
                blnResult = false;
            }

            return blnResult;
        }

        public static bool isStateValid(string temp)
        {
            bool blnResult = true;

            if (temp.Length != 2)
            {
                blnResult = false;
            }

            return blnResult;
        }
        public static bool isinstaurlValid(string temp)
        {
            bool blnResult = true;

            int atLoc = temp.IndexOf(".");
            int NextatLoc = temp.IndexOf(".", atLoc + 1);

            int periodloc = temp.LastIndexOf(".");

            
            return blnResult;
        }
    }
}