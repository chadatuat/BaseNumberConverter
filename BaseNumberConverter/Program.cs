// Chad Weirick
// UAT MS507
// This is the main program module.
// This program presents a UI, allows a user to enter a value and an input and output base and convert them.  The result will be shown in its own message box at the end of the conversion.
// note: this program can be modified, specifically the limit of what constitutes a valid character for conversion.  These can be extended or modified to the users needs.  At present the system supports up to base 36.
// v1.01
// changes: added security to prevent an endless loop when converting a blank line of text.
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
        // These are the acceptable characters.  Modifying these dynamically changes the program, but you will need to manually adjust the array limit on the line after next.
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
            int iThisEntry = 1;
            foreach (char cThisItem in cArrayChars)
            {
                iThisEntry++;
                iArrayCount[(iThisEntry - 2)] = iThisEntry;
            }
        }
    }
}
