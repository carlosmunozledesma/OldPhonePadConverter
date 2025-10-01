
namespace OldPhonePadConverter
{
    public class Program
    {
        public static void Main()
        {
            ShowGreedings();
            string message = GetMessageFromUser();
            while (!string.IsNullOrEmpty(message) && !IsMessageToExit(message))
            {
                var result = OldPhonePadConverter.OldPhonePad(message);

                ShowResult(result);

                message = GetMessageFromUser();

            }
        }

        private static void ShowGreedings()
        {
            Console.WriteLine(Constants.Messages.HyphenMenu);
            Console.WriteLine(Constants.Messages.TitleMenu);
            Console.WriteLine(Constants.Messages.HyphenMenu);
            Console.WriteLine(Constants.Messages.NewLine);
            Console.WriteLine(Constants.Messages.ExplanationMenu);
        }

        private static string GetMessageFromUser()
        {
            Console.WriteLine(Constants.Messages.NewLine);
            Console.WriteLine(Constants.Messages.EnterMessage);
            string? message = Console.ReadLine();
            while (string.IsNullOrEmpty(message) || !message.Contains(Constants.Keypads.LastCharacterSentinel))
            {
                Console.WriteLine(Constants.Messages.EmptyOrIncompletedMessage);
                Console.WriteLine(Constants.Messages.NewLine);
                Console.WriteLine(Constants.Messages.EnterMessage);
                message = Console.ReadLine();
            }
            return message;
        }

        private static bool IsMessageToExit(string? message)
        {
            return String.Equals(message, Constants.Keypads.Exit,
                   StringComparison.OrdinalIgnoreCase);
        }

        private static void ShowResult(string result)
        {
            Console.WriteLine(Constants.Messages.OutputMessage + result);
        }
    }
}
