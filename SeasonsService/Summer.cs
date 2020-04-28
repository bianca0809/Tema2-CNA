using System;
using SeasonsService.Models;

namespace SeasonsService
{
    public static class Summer
    {

        static Sign Cancer { get; set; } = new Sign()
        {
            startDate = DateTime.Parse("06/21/0001"), 
            endDate = DateTime.Parse("07/23/0001"),
            signName = SignType.Cancer
        };
        static Sign Leo { get; set; } = new Sign()
        {
            startDate = DateTime.Parse("07/23/0001"),
            endDate = DateTime.Parse("08/23/0001"),
            signName = SignType.Leo
        };
        static Sign Virgo { get; set; } = new Sign()
        {
            startDate = DateTime.Parse("08/23/0001"),
            endDate = DateTime.Parse("09/01/0001"),
            signName = SignType.Virgo
        };
        static Sign Gemini { get; set; } = new Sign()
        {
            startDate = DateTime.Parse("06/01/0001"),
            endDate = DateTime.Parse("06/21/0001"),
            signName = SignType.Gemini
        };


        public static string GetZodiacSign(string input)
        {
            DateTime dt = DateTime.Parse(input);
            dt = dt.AddYears(0 - dt.Year + 1); 

            if (dt.Date >= Cancer.startDate && dt.Date < Cancer.endDate)
                return Cancer.signName.ToString();
            if (dt.Date >= Leo.startDate && dt.Date < Leo.endDate)
                return Leo.signName.ToString();
            if (dt.Date >= Virgo.startDate && dt.Date < Virgo.endDate)
                return Virgo.signName.ToString();
            if (dt.Date >= Gemini.startDate && dt.Date < Gemini.endDate)
                return Gemini.signName.ToString();

            return "InvalidRequest";
        }
    }
}
