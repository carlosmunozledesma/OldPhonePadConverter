
namespace OldPhonePadConverter
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("----- Old Phone Pad Converter to Text -----");

            Console.WriteLine("Write exit to stop the program.");
            Console.WriteLine("Enter a message to convert:");
            string? message = Console.ReadLine();

            while (!String.Equals(message, Constants.Keypads.Exit,
                   StringComparison.OrdinalIgnoreCase))
            {
                while (string.IsNullOrEmpty(message) || !message.Contains(Constants.Keypads.LastCharacterSentinel))
                {
                    Console.WriteLine("No message entered or incompleted, add # at the end.");
                    Console.WriteLine("Enter a message to convert:");
                    message = Console.ReadLine();
                }

                var result = OldPhonePadConverter.OldPhonePad(message);
                Console.WriteLine("Old Phone Pad output:" + result);

                Console.WriteLine("Enter another message to convert:");
                message = Console.ReadLine();
            }

        }
    }
}
