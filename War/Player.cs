using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace War
{
    public class Player
    {
        public List<Card> PlayerCards { get; set; }
        public string Name { get; set; }
        public int WarsWon { get; set; }
        private int winstreak;
        public int WinStreak {
            get { return winstreak; }
            set {
                winstreak = value;
                if (winstreak > LongStreak) { LongStreak = winstreak; }
            }
        }
        public int LongStreak { get; set; }
        public Player()
        {
            PlayerCards = new List<Card>();
            WarsWon = 0;
            WinStreak = 0;
            LongStreak = 0;
        }
        public Card GetCard()
        {
            Card c = PlayerCards.First();
            PlayerCards.Remove(c);
            return c;
        }
        public IEnumerable<Card> GetCards(int howMany)
        {
            int count = howMany < PlayerCards.Count - 1 ? howMany : PlayerCards.Count - 1;
            var cards = PlayerCards.Take<Card>(count).ToList();
            foreach (var c in cards)
            {
                PlayerCards.Remove(c);
            }
            return cards;
            
        }
    }
}
