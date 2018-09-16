using System;
using System.Linq;

namespace HoloalphabeticSentence
{
    public class HoloalphabeticSentence
    {
        // Write the logic to determine whether the input string is a HoloalphabeticSentence or not
        public static bool IsHoloalphabeticSentence(string input, string alphabets = "abcdefghijklmnopqrstuvwxyz")
        {
            
            //convert all character to lower to avoid mismatch
            input=input.ToLower();
            foreach(char c in alphabets)
            {
                if(!(input.Contains(c)))
                    return false;
            }
           return true;
        }
    }
}
