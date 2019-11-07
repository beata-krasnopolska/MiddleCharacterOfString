using System;

namespace MiddleCharacterOfString
{
    class MiddleFinder
    {
        public string FindMiddle(string userString)
        {
            var middleOfWord = (userString.Length - 1) / 2;
            if (string.IsNullOrEmpty(userString))
            {
                return "empty string";
            }
            if (IsLengthOne(userString))
            {
                return userString;
            }
            if (IsLengthEven(userString))
            {
                return userString.Substring(middleOfWord, 2);
            }
               return userString.Substring(middleOfWord, 1);
        }
        private bool IsLengthOne (string userString)
        {
            return userString.Length == 1;
        }
        private bool IsLengthEven(string userString)
        {
            return userString.Length % 2 == 0;
        }
    }
}
