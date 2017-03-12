using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace War
{
    public class Deck
    {
        public List<Card> Cards { get; set; }
        public Deck()
        {
            
            Cards = new List<Card>();
            for (var i = 0; i < 4; i++)
            {
                string suit;
                suit = Enum.GetName(typeof(Suits), i);
                for (var j = 0; j < 13; j++)
                {
                    var card = new Card();
                    card.Suit = suit;
                    card.Name = Enum.GetName(typeof(CardValues), j);
                    card.Rank = j;
                    Cards.Add(card);
                }
            }
        }
        public void Shuffle()
        {
            
            var randomizedList = new List<Card>();
            var rnd = new Random();
            while (Cards.Count != 0)
            {
                var index = rnd.Next(0, Cards.Count);
                randomizedList.Add(Cards[index]);
                Cards.RemoveAt(index);
            }
            Cards = randomizedList;
        }
        public void Deal(List<Player> players)
        {
            int i = 1;
            foreach (var card in Cards)
            {
                if (i % 2 == 0) { players.Last().PlayerCards.Add(card); }
                else { players.First().PlayerCards.Add(card); }
                i++;
            }

        }
        
    }
}
