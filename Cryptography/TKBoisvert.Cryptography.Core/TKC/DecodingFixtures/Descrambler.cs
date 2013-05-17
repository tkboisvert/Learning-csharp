namespace TKBoisvert.Cryptography.Core
{
    public class Descrambler
    {
        public int SubtractKey(int first, int second)
        {
            return first -= second;
        }

        public int[] Descramble(int[] scrambledText, int[] codePhrase)
        {
            int[] DecodedText = new int[scrambledText.Length];

            int x = 0;

            int y = 0;

            foreach (int i in scrambledText)
            {
                if (x == codePhrase.Length)
                {
                    x = 0;
                }
                DecodedText[y] = SubtractKey(i, codePhrase[x]);
                x++;
                y++;
            }

            return DecodedText;
        }

        public string ASCIIToString(int i)
        {
            char character = (char)i;
            return (character.ToString());
        }

        public string ArrayOfASCIIToString(int[] arrayOfASCIIValues)
        {
            string text = "";

            foreach (int i in arrayOfASCIIValues)
            {
                text += ASCIIToString(i);
            }

            return text;
        }
    }
}