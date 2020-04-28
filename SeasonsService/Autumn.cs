using System;
using SeasonsService.Models;

namespace SeasonsService
{
    public static class Autumn
    {

        static Sign Scorpio { get; set; } = new Sign()
        {
            startDate = DateTime.Parse("10/22/0001"), 
            endDate = DateTime.Parse("11/22/0001"), 
            signName = SignType.Scorpio
        };
        static Sign Sagittarius { get; set; } = new Sign()
        {
            startDate = DateTime.Parse("11/22/0001"),
            endDate = DateTime.Parse("12/01/0001"),
            signName = SignType.Sagittarius
        };
        static Sign Virgo { get; set; } = new Sign()
        {
            startDate = DateTime.Parse("09/01/0001"),
            endDate = DateTime.Parse("09/23/0001"),
            signName = SignType.Virgo
        };
        static Sign Libra { get; set; } = new Sign()
        {
            startDate = DateTime.Parse("09/23/0001"),
            endDate = DateTime.Parse("10/22/0001"),
            signName = SignType.Libra
        };


        public static string GetZodiacSign(string input)
        {
            DateTime dt = DateTime.Parse(input);
            dt = dt.AddYears(0 - dt.Year + 1); 

            if (dt.Date >= Libra.startDate && dt.Date < Libra.endDate)
                return Libra.signName.ToString();
            if (dt.Date >= Sagittarius.startDate && dt.Date < Sagittarius.endDate)
                return Sagittarius.signName.ToString();
            if (dt.Date >= Virgo.startDate && dt.Date < Virgo.endDate)
                return Virgo.signName.ToString();
            if (dt.Date >= Scorpio.startDate && dt.Date < Scorpio.endDate)
                return Scorpio.signName.ToString();

            return "InvalidRequest";
        }
    }
}
