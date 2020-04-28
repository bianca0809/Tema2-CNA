using System;
using SeasonsService.Models;

namespace SeasonsService
{
    public static class Winter
    {

        static Sign Capricorn { get; set; } = new Sign()
        {
            startDate = DateTime.Parse("12/22/0001"), 
            endDate = DateTime.Parse("01/20/0001"), 
            signName = SignType.Capricorn
        };
        static Sign Sagittarius { get; set; } = new Sign()
        {
            startDate = DateTime.Parse("12/01/0001"),
            endDate = DateTime.Parse("12/22/0001"),
            signName = SignType.Sagittarius
        };
        static Sign Aquarius { get; set; } = new Sign()
        {
            startDate = DateTime.Parse("01/20/0001"),
            endDate = DateTime.Parse("02/19/0001"),
            signName = SignType.Aquarius
        };
        static Sign Pisces { get; set; } = new Sign()
        {
            startDate = DateTime.Parse("02/19/0001"),
            endDate = DateTime.Parse("03/01/0001"),
            signName = SignType.Pisces
        };


        public static string GetZodiacSign(string input)
        {
            DateTime dt = DateTime.Parse(input);
            dt = dt.AddYears(0 - dt.Year + 1);

            if (dt.Date >= Capricorn.startDate && dt.Date < Capricorn.endDate)
                return Capricorn.signName.ToString();
            if (dt.Date >= Sagittarius.startDate && dt.Date < Sagittarius.endDate)
                return Sagittarius.signName.ToString();
            if (dt.Date >= Aquarius.startDate && dt.Date < Aquarius.endDate)
                return Aquarius.signName.ToString();
            if (dt.Date >= Pisces.startDate && dt.Date < Pisces.endDate)
                return Pisces.signName.ToString();

            return "InvalidRequest";
        }
    }
}
