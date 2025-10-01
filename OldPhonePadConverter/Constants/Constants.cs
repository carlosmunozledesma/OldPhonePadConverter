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

    public static class Messages
    {
        public const string HyphenMenu = "-------------------------------------------";
        public const string TitleMenu = "----- Old Phone Pad Converter to Text -----";
        public const string ExplanationMenu = "Type a message with '#' at the end or write 'exit' to stop the program.";
        public const string NewLine = "\r";
        public const string EnterMessage = "Enter a message to convert: ";
        public const string EmptyOrIncompletedMessage = "No message entered or incompleted, add # at the end.";
        public const string OutputMessage = "Old Phone Pad output: ";
    }
}
