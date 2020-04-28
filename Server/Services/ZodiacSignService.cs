using System.Threading.Tasks;
using Grpc.Core;

namespace Server
{
    public class ZodiacSignService : ZodiacSign.ZodiacSignBase
    {
        public override Task<ZodiacReply> GetSign(ZodiacRequest request, ServerCallContext context)
        {
            return Task.FromResult(new ZodiacReply
            {
                ZodiacSign = "Zodiac sign: " + FindBySeason(request.DateOfBirth)
            });
        }

        private string FindBySeason(string input) 
        {
            string month = input.Substring(0, 2);
            switch (month)
            {
                case "12":
                case "01":
                case "02":
                    return SeasonsService.Winter.GetZodiacSign(input);
                case "03":
                case "04":
                case "05":
                    return SeasonsService.Spring.GetZodiacSign(input);
                case "06":
                case "07":
                case "08":
                    return SeasonsService.Summer.GetZodiacSign(input);
                case "09":
                case "10":
                case "11":
                    return SeasonsService.Autumn.GetZodiacSign(input);
            }
            return "Invalid request";
        }
    }
}
