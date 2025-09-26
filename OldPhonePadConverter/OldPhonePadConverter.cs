using OldPhonePadConverter.Constants;
using System.Text;

namespace OldPhonePadConverter
{
    public static class OldPhonePadConverter
    {
        public static string OldPhonePad(string input)
        {
            if (string.IsNullOrEmpty(input) || !input.Contains(Keypads.LastCharacterSentinel))
            {
                return "";
            }

            var result = new StringBuilder();
            int position = 0;

            // Iterate all the message until the centinela character is found
            while (input[position] != Keypads.LastCharacterSentinel)
            {
                char currentChar = input[position];
                if (Keypads.OldKeypadDictionary.ContainsKey(currentChar))
                {
                    // Check backspaces using *
                    if (currentChar == Keypads.BackspaceCharacter)
                    {
                        if (result.Length > 0)
                        {
                            result.Remove(result.Length - 1, 1);
                        }
                        position++;
                        continue;
                    }

                    // Check how many times are pressed the same button consecutively
                    int count = 1;
                    while (position + 1 < input.Length && input[position + 1] == currentChar)
                    {
                        count++;
                        position++;
                    }

                    // Get the characters from the dictionary
                    string charactersFromDic = Keypads.OldKeypadDictionary[currentChar];
                    if (charactersFromDic.Length > 0)
                    {
                        // Index of the character to select
                        int index = (count - 1) % charactersFromDic.Length;
                        result.Append(charactersFromDic[index]);
                    }
                }
                // Next character
                position++;
            }
            return result.ToString();
        }
    }
}

