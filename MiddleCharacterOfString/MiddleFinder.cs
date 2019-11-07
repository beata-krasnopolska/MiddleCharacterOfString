using System;

namespace MiddleCharacterOfString
{
    class MiddleFinder
    {
        public string FindMiddle(string userString)
        {
            string middleString = "";
            if (string.IsNullOrEmpty(userString))
            {
                middleString = "empty string";
            }
            else if (userString.Length < 2)
            {
                middleString = userString.Substring((userString.Length - 1) / 2, Math.Min(userString.Length,2));
            }
            else if(userString.Length %2 == 0)
            {
                middleString = userString.Substring((userString.Length - 1) / 2, 2);
            }
            else if (userString.Length % 2 != 0)
            {
                middleString = userString.Substring((userString.Length - 1) / 2, 1);
            }
            return middleString;
        }
    }
}
