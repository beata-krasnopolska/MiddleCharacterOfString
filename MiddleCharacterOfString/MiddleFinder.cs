
namespace MiddleCharacterOfString
{
    class MiddleFinder
    {
        public string FindMiddle(string userString)
        {            
            if (string.IsNullOrEmpty(userString))
            {
                return "empty string";
            }

            if (IsOne(userString.Length))
            {
                return userString;
            }

            var middleOfWord = (userString.Length - 1) / 2;

            if (IsEven(userString.Length))
            {
                return userString.Substring(middleOfWord, 2);
            }

            return userString.Substring(middleOfWord, 1);
        }

        private bool IsOne (int length)
        {
            return length == 1;
        }

        private bool IsEven(int length)
        {
            return length % 2 == 0;
        }
    }
}
