using Grpc.Net.Client;
using System;
using System.Threading.Tasks;
using Server;
using System.Globalization;

namespace Client
{
    class Program 
    {
        static async Task Main(string[] args)
        {
            using var channel = GrpcChannel.ForAddress("https://localhost:5001");
            var client = new ZodiacSign.ZodiacSignClient(channel);
            Console.WriteLine("Enter your date of birth: ");

            while (true) 
            {
                var input = Console.ReadLine();
                if (ValidateInput(input))
                {
                    var reply = await client.GetSignAsync(
                        new ZodiacRequest { BirthDate = input });
                    Console.WriteLine(reply.ZodiacSign);
                    break;
                }
                Console.WriteLine("Invalid! Please respect the format (mm/dd/yyyy) and try again.");
            }
            Console.ReadKey();
        }

        static bool ValidateInput(string userInput) 
        {
            DateTime dt = new DateTime();
            string format = "mm/dd/yyyy";

            if (DateTime.TryParseExact(userInput, format, 
                CultureInfo.InvariantCulture, 
                DateTimeStyles.None, out dt)) 
            {
                return true;
            }
            return false;
        } 
    }
}
