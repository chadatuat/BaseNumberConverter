﻿/// Chad Weirick
/// 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaseNumberConverter
{
    
    static class Program
    {
        /// 
        /// Base entry point
        /// 
        public static char[] cArrayChars = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
        public static int[] iArrayCount = new int[36];
        

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            BuildCountArray();
            Application.Run(new MainWindows());
         
        }

        static void BuildCountArray()
        {
            int iThisEntry = 0;
            foreach (char cThisItem in cArrayChars)
            {
                iThisEntry++;
                iArrayCount[(iThisEntry - 1)] = iThisEntry;
            }
        }
    }
}