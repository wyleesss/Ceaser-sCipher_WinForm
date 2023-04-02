namespace Ceaser_sCipher_WinForm
{
    public class CipherSource
    {
        public static string Cipher(string InputWord, int Key, bool isDecoding = false)
        {
            if (isDecoding)
                Key *= -1;

            string UpperUkrAlphabet = new string("АБВГҐДЕЄЖЗИІЇЙКЛМНОПРСТУФХЦЧШЩЬЮЯ");
            string LowerUkrAlphabet = new string("абвгґдеєжзиіїйклмнопрстуфхцчшщьюя");
            string UpperEngAlphabet = new string("ABCDEFGHIJKLMNOPQRSTUVWXYZ");
            string LowerEngAlphabet = new string("abcdefghijklmnopqrstuvwxyz");

            string Result = new string(string.Empty);
            string Temp = new string(string.Empty);

            int Index = 0;

            InputWord = InputWord.Replace(" ", "");

            foreach (char i in InputWord)
            {
                if (Char.IsLetter(i))
                {
                    if (!UpperUkrAlphabet.Contains(i) && !LowerUkrAlphabet.Contains(i)
                        && !UpperEngAlphabet.Contains(i) && !LowerEngAlphabet.Contains(i))
                    {
                        return "!дана мова не підтримується програмою. доступні мови: українська; англійська.";
                    }
                }
            }

            foreach (char letter in InputWord)
            {
                if (UpperUkrAlphabet.Contains(letter))
                    Temp = UpperUkrAlphabet;

                else if (LowerUkrAlphabet.Contains(letter))
                    Temp = LowerUkrAlphabet;

                else if (UpperEngAlphabet.Contains(letter))
                    Temp = UpperEngAlphabet;

                else if (LowerEngAlphabet.Contains(letter))
                    Temp = LowerEngAlphabet;

                else
                {
                    Result += letter;
                    continue;
                }

                Index = Temp.IndexOf(letter);

                if (Index + Key <= Temp.Length - 1 && Index + Key >= 0)
                    Result += Temp[Index + Key];

                else if (Index + Key > Temp.Length - 1)
                    Result += Temp[(Index + Key) % Temp.Length];

                else
                    Result += Temp[(Temp.Length + (Index + Key) % Temp.Length) % Temp.Length];
            }

            return Result;
        }
    }
}