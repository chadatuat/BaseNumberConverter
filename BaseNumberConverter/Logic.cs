// Chad Weirick
// UAT MS507
// This is the logic/math module.
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
        public static bool AllValidCharacters(String sTestThis, List<char> lValidChars, int iBaseUnit)       
        {
            
            bool bReturnMe = true;
            foreach (char c in sTestThis)
            {
                if (lValidChars.GetRange(0, iBaseUnit).Contains(c))
                {
                    // do nothing
                } else
                {
                    bReturnMe = false;
                }
            }
            return bReturnMe;
        }

        public static string ConvertBase(String sConvertThis, int iInputBase, int iOutputBase)
        {
            List<char> iCharArrayInput = Program.cArrayChars.ToList().GetRange(0, iInputBase);
            String sReturnMe = "";
            int iValueInIntegerFormat = 0;
            int iPlaceValue = sConvertThis.Length - 1;
            int iMaxValue = 0;
            int iLeftOverValue = 0;
            int iCurrentExponent = 0;
            int iCurrentValue = 0;


            // determine the current integer value for the input
            foreach (char cThisChar in sConvertThis)
            {
                iValueInIntegerFormat += iCharArrayInput.IndexOf(cThisChar) * Convert.ToInt32(Math.Pow(Convert.ToDouble(iInputBase), Convert.ToDouble(iPlaceValue)));
                iPlaceValue--;
            }

            
            do
            {
                iCurrentExponent = 0;
                // is iValueInIntegerFormat > the iOutputBase?  If so, the number of times which it is (iMaxValue) is the character that goes in the next sReturnMe spot
                // for example, 10010 in binary (base 2) going to decimal (Base 10) ends up as 18.  
                // 18 mod 10 is 8
                // (18 - 8) / 10 is 1
                // 18 - 10 is 8
                // 8 is less than or equal to the iOutputbase of 10, so it is just appended to end of sReturnMe and the equation is closed.

                // determine the number of places in the new base system
                do
                    {
                        iCurrentExponent++;
                    } while (Convert.ToInt32(Math.Pow(Convert.ToDouble(iOutputBase), Convert.ToDouble(iCurrentExponent))) < iValueInIntegerFormat);

                    iCurrentExponent--;
                    iCurrentValue = 0;

                // increase the n in n * base ^ biggestpossible exponent just discovered
                // is it <= iValueInIntegerFormat?  
                do
                {
                    iCurrentValue++;
                } while (iCurrentValue * Convert.ToInt32(Math.Pow(Convert.ToDouble(iOutputBase), Convert.ToDouble(iCurrentExponent))) <= iValueInIntegerFormat);
                iCurrentValue--;
                sReturnMe += Program.cArrayChars[iCurrentValue];
                iValueInIntegerFormat = iValueInIntegerFormat - iCurrentValue * Convert.ToInt32(Math.Pow(Convert.ToDouble(iOutputBase), Convert.ToDouble(iCurrentExponent)));
                // now that the first character is found, all other characters need to be walked back until the value of iValueInIntegerFormat is 0.
                do
                {
                    iCurrentExponent--;
                    iCurrentValue = 0;
                    do
                    {
                        iCurrentValue++;
                    } while (iCurrentValue * Convert.ToInt32(Math.Pow(Convert.ToDouble(iOutputBase), Convert.ToDouble(iCurrentExponent))) <= iValueInIntegerFormat);
                    iCurrentValue--;
                    sReturnMe += Program.cArrayChars[iCurrentValue];
                    iValueInIntegerFormat = iValueInIntegerFormat - iCurrentValue * Convert.ToInt32(Math.Pow(Convert.ToDouble(iOutputBase), Convert.ToDouble(iCurrentExponent)));

                } while (iCurrentExponent > 0);

            } while (iValueInIntegerFormat > 0);
           
            return sReturnMe;
        }
        
    }
}
