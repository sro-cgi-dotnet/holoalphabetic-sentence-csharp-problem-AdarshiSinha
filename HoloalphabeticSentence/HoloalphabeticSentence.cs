using System;
using System.Linq;

namespace HoloalphabeticSentence
{
    public class HoloalphabeticSentence
    {
        // Write the logic to determine whether the input string is a HoloalphabeticSentence or not
        public static bool IsHoloalphabeticSentence(string input, string alphabets = "abcdefghijklmnopqrstuvwxyz")
        {
            int[] a= new int[26];
            
            input=input.ToLower();
            for(int i=0;i<input.Length;i++)
            {
                if(input[i]>='a' && input[i]<='z')
                a[input[i]-97]++;
            }
            foreach(int j in a)
            {
                if(j==0)
                {
                    return false;
                    break;
                }
            }
            return true;
        }
    }
}
