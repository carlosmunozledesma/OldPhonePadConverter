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
                return string.Empty;
            }

            var result = new StringBuilder();
            int position = 0;

            // Iterate all the message until the sentinel character is found
            while (input[position] != Keypads.LastCharacterSentinel)
            {
                char currentChar = input[position];
                if (Keypads.OldKeypadDictionary.ContainsKey(currentChar))
                {
                    // Check backspaces using *
                    if (currentChar == Keypads.BackspaceCharacter)
                    {
                        RemoveBackspace(result);
                        position++;
                        continue;
                    }

                    // Check how many times are pressed the same button consecutively and update position and counter
                    int count = 1;
                    SameButtonPressed(input, ref position, ref count);

                    // Get the characters from the dictionary and append the correct character to the result
                    string charactersFromDic = Keypads.OldKeypadDictionary[currentChar];
                    AddCharactersToResult(result, charactersFromDic, count);
                    
                }
                // Next character
                position++;
            }
            return result.ToString();
        }

        private static void RemoveBackspace(StringBuilder result)
        {
            if (result.Length > 0)
                result.Remove(result.Length - 1, 1);
        }

        private static void SameButtonPressed(string input, ref int position, ref int count)
        {
            while (position + 1 < input.Length && input[position + 1] == input[position])
            {
                count++;
                position++;
            }
        }

        private static void AddCharactersToResult(StringBuilder result, string charactersFromDic, int count)
        {
            if (charactersFromDic.Length > 0)
            {
                // Index of the character to select
                int index = (count - 1) % charactersFromDic.Length;
                result.Append(charactersFromDic[index]);
            }
        }
    }
}

