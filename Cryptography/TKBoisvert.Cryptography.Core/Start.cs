namespace TKBoisvert.Cryptography.Core
{
    internal class Start
    {
        public static void TKC(char[] charArray)
        {
            AstheticTextAndPieces ATaP = new AstheticTextAndPieces();
            string oneForEncodingTwoForDecoding = ATaP.Menu();

            string stringToBeConverted = Change.ChangeToFormattedStringForConversion(charArray);

            if (oneForEncodingTwoForDecoding == "1")
            {
                ProgramForEncoding.Encode(stringToBeConverted);
            }
            else if (oneForEncodingTwoForDecoding == "2")
            {
                ProgramForDecoding.Decode(stringToBeConverted);

                // change selector string to a console key so the read key doesn't bleed over to the GET PASS PHRASE.
            }
        }
    }
}