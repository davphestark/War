using System.Collections.Generic;
using System.Linq;

namespace War
{
    public class Battle
    {
        public List<Card> CardStore { get; set; }
        public bool IsWar { get; set; }
        public Battle()
        {
            CardStore = new List<Card>();
        }
        public string StartBattle(Player player1, Player player2) 
        {
            var cards = GetBattleCards(new List<Player>() { player1, player2 });
            if (cards.First().Rank > cards.Last().Rank)
            {
                return VictoryFor(player1, player2, cards);
            }
            if (cards.First().Rank < cards.Last().Rank)
            {
                cards.Reverse();
                return VictoryFor(player2, player1, cards);
            }
            if (cards.First().Rank == cards.Last().Rank)
            {
                IsWar = true;
                var winner = IfAPlayerOutOfCards(player1, player2);
                if (!VictorGetsTheCards(winner))
                { 
                    AddCardsToStore(player1.GetCards(3));
                    AddCardsToStore(player2.GetCards(3));
                    return "***WAR:" + cards.First().Name + "'s***\n" + StartBattle(player1, player2);
                } else {
                    return string.Format($"{winner.Name} wins by default {cards.First().ShortName} to {cards.Last().ShortName} on Last card\n");
                }
            }
            return "";
        }

        private string VictoryFor(Player winner, Player loser, List<Card> cards)
        {
            VictorGetsTheCards(winner);
            updateStreak(winner, loser);
            return printOutAction(winner.Name, cards.First(), cards.Last());
        }
        private bool VictorGetsTheCards(Player player)
        {
            if (player != null)
            {
                player.PlayerCards.AddRange(CardStore);
                return true;
            }
            return false;
        }
        private List<Card> GetBattleCards(List<Player> players)
        {
            var cards = new List<Card>();
            foreach (Player p in players)
            {
                cards.Add(p.GetCard());
            }
            AddCardsToStore(cards);
            return cards;
        }

        private Player IfAPlayerOutOfCards(Player player1, Player player2)
        {
            if (player1.PlayerCards.Count == 0) { return player2; }
            if (player2.PlayerCards.Count == 0) { return player1; }
            return null;
        }

        private void updateStreak(Player winner, Player loser)
        {
            winner.WinStreak += 1;
            loser.WinStreak = 0;
            if (IsWar)
            {
                winner.WarsWon++;
                IsWar = false;
            }
        }
        private string printOutAction(string victor, Card card1, Card card2)
        {
            //return string.Format($"{victor}'s {card1.Name} of {card1.Suit} beats {card2.Name} of {card2.Suit}\n");
            return string.Format($"{victor}'s {card1.ShortName} beats {card2.ShortName}\n");
        }
        
        public void AddCardsToStore(IEnumerable<Card> cards)
        {
            CardStore.AddRange(cards);
        }
    }
}
