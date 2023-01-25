using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API_palindrome.Models
{
    public class Logic
    {
        LDBContext db = new LDBContext();
        public List<String> allPalindromeSubstring(String s)
        {
            List<String> list = new List<String>();

            // moving the pivot from starting till end of the string
            for (int i = 0; i < s.Length; i++)
            {

                // set radius to the first nearest element
                // on left and right
                int palindromeRadius = (i + 1) - i;

                // if the position needs to be compared has an element
                // and the characters at left and right matches
                while ((i + palindromeRadius) < s.Length && (i >= 0 && s[(i)] == s[(i + palindromeRadius)]))
                {

                    list.Add(s.Substring((i),
                                (i + palindromeRadius + 1) - (i)));
                    palindromeRadius++;
                }
                    // increasing the radius by 1 to point to the
                    // next elements in left and right
                    while ((i + palindromeRadius) < s.Length && (i - palindromeRadius >= 0 && s[(i - palindromeRadius)] == s[(i + palindromeRadius)]))
                    {

                        list.Add(s.Substring((i - palindromeRadius),
                                    (i + palindromeRadius + 1) - (i - palindromeRadius)));

                        palindromeRadius++;
                    }
                }

                return list;
            }
            public List<string> First(string str)
            {
                List<string> list = allPalindromeSubstring(str);
                return list;
            }
           
    } 
}

