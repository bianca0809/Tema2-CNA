using System;
using SeasonsService.Models;

namespace SeasonsService
{
    public static class Spring
    {
        
        static Sign Piesces { get; set; } = new Sign() 
        { 
            startDate = DateTime.Parse("03/01/0001"), 
            endDate = DateTime.Parse("03/21/0001"),
            signName = SignType.Pisces 
        };
        static Sign Aries { get; set; } = new Sign()
        {
            startDate = DateTime.Parse("03/21/0001"),
            endDate = DateTime.Parse("04/20/0001"),
            signName = SignType.Aries
        };
        static Sign Taurus { get; set; } = new Sign()
        {
            startDate = DateTime.Parse("04/21/0001"),
            endDate = DateTime.Parse("05/21/0001"),
            signName = SignType.Taurus
        };
        static Sign Gemini { get; set; } = new Sign()
        {
            startDate = DateTime.Parse("05/21/0001"),
            endDate = DateTime.Parse("06/01/0001"),
            signName = SignType.Gemini
        };


        public static string GetZodiacSign(string input) {
            DateTime dt = DateTime.Parse(input);
            dt = dt.AddYears(0 - dt.Year + 1); 

            if (dt.Date >= Piesces.startDate && dt.Date < Piesces.endDate)
                return Piesces.signName.ToString();
            if (dt.Date >= Aries.startDate && dt.Date < Aries.endDate)
                return Aries.signName.ToString();
            if (dt.Date >= Taurus.startDate && dt.Date < Taurus.endDate)
                return Taurus.signName.ToString();
            if (dt.Date >= Gemini.startDate && dt.Date < Gemini.endDate)
                return Gemini.signName.ToString();

            return "InvalidRequest";
        }
    }
}
