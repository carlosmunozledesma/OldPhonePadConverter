
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
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("----- Old Phone Pad Converter to Text -----");
            Console.WriteLine("-------------------------------------------");

            Console.WriteLine("Write exit to stop the program.");
        }

        private static string GetMessageFromUser()
        {
            Console.WriteLine("Enter a message to convert: ");
            string? message = Console.ReadLine();
            while (string.IsNullOrEmpty(message) || !message.Contains(Constants.Keypads.LastCharacterSentinel))
            {
                Console.WriteLine("No message entered or incompleted, add # at the end.");
                Console.WriteLine("Enter a message to convert:");
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
            Console.WriteLine("Old Phone Pad output: " + result);
        }
    }
}
