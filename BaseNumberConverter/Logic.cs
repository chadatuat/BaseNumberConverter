
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseNumberConverter
{
    public static class Logic
    {
        // look at each char the sTestThis and be sure they are in the valid characters array
        public static bool AllValidCharacters(String sTestThis, List<char> lValidChars)
        {
            bool bReturnMe = true;
            foreach (char c in sTestThis)
            {
                if (lValidChars.Contains(c))
                {
                    // do nothing
                } else
                {
                    bReturnMe = false;
                }
            }
            return bReturnMe;
        }
    }
}
