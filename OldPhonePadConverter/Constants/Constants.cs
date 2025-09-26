namespace OldPhonePadConverter.Constants
{
    public static class Keypads
    {
        public static readonly IReadOnlyDictionary<char, string> OldKeypadDictionary = new Dictionary<char, string>
        {
            {'1', "&'("},
            {'2', "ABC"},
            {'3', "DEF"},
            {'4', "GHI"},
            {'5', "JKL"},
            {'6', "MNO"},
            {'7', "PQRS"},
            {'8', "TUV"},
            {'9', "WXYZ"},
            {'*', ""},
            {'0', " "},
            {'#', ""},
        };

        public const char LastCharacterSentinel = '#';
        public const char BackspaceCharacter = '*';
        public const string Exit = "exit";
    }
}
