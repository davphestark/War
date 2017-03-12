using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace War
{
    public class Card
    {
        public string Name { get; set; }
        public int Rank { get; set; }
        public string Suit { get; set; }

        public string ShortName
        {
            get
            {
                return ConvertToShortName();
            }
        }

        private string ConvertToShortName()
        {
            string shortCardName = GetShortCardValue(Name);
            string suitSymbol = char.ConvertFromUtf32(int.Parse(GetUnicodeValueForSuit(Suit), System.Globalization.NumberStyles.HexNumber)).ToString();
            return shortCardName + suitSymbol;
        }

        private string GetShortCardValue(string name)
        {
            if (name == "Two") { return " 2"; }
            if (name == "Three") { return " 3"; }
            if (name == "Four") { return " 4"; }
            if (name == "Five") { return " 5"; }
            if (name == "Six") { return " 6"; }
            if (name == "Seven") { return " 7"; }
            if (name == "Eight") { return " 8"; }
            if (name == "Nine") { return " 9"; }
            if (name == "Ten") { return "10"; }
            if (name == "Jack") { return " J"; }
            if (name == "Queen") { return " Q"; }
            if (name == "King") { return " K"; }
            return " A";
        }

        private string GetUnicodeValueForSuit(string suit)
        {
            if (suit == "Clubs") { return "2663"; }
            if (suit == "Hearts") { return "2665"; }
            if (suit == "Diamonds") { return "2666"; }
            return "2660"; 
        }
    }
}
