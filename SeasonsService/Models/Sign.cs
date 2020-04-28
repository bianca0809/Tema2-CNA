using System;
using System.Collections.Generic;
using System.Text;

namespace SeasonsService.Models
{
    public enum SignType 
    { 
        Pisces,
        Aries,
        Taurus,
        Gemini,
        Cancer,
        Leo,
        Virgo,
        Libra,
        Scorpio,
        Sagittarius,
        Capricorn,
        Aquarius,
    }
    public class Sign
    {
        public SignType signName { get; set; }
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }
        public Sign()
        {
        }
    }
}
