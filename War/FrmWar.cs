using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace War
{
    public partial class FrmWar : Form
    {
        private Deck deck { get; set; }
        private int TotalBattles = 0;
        private List<Player> players;
        public FrmWar()
        {
            InitializeComponent();
            deck = new Deck();
            players = new List<Player>() { InitPlayer(lblPlayer1.Text), InitPlayer(lblPlayer2.Text) };
            deck.Shuffle();
            deck.Deal(players);
        }

        private Player InitPlayer(string text)
        {
            Player player = new Player();
            player.Name = text;
            return player;
        }

        private void btnReStart_Click(object sender, EventArgs e)
        {
            deck.Shuffle();
            ResetPlayers();
            deck.Deal(players);
            ResetPlayersStats();
            rtbResults.Clear();
            TotalBattles = 0;
            btnBattle.Enabled = true;
        }
        private void ResetPlayers()
        {
            players = null;
            players = new List<Player>() { InitPlayer(lblPlayer1.Text), InitPlayer(lblPlayer2.Text) };
        }
        private void ResetPlayersStats()
        {
            ClearStats(lblStats1);
            ClearStats(lblStats2);
        }

        private void ClearStats(Label label)
        {
            label.Text = "";
        }     

        private async void btnBattle_Click(object sender, EventArgs e)
        {
            int index = 5;
            while (index == 5)
            {
                var b = new Battle();
                if (chkSlowPlay.Checked) { ProcessTextForResults(await AsyncStartBattleSlow(b)); }
                else { ProcessTextForResults(await AsyncStartBattle(b)); }
                TotalBattles++;
                updateStats();
                if (IsThereAVictor(out index))
                {
                    MessageBox.Show(String.Format($"{players[index].Name} Is Victorus! \nAfter {TotalBattles} battles"));
                    btnBattle.Enabled = false;
                };
            }
        }

        private Task<string> AsyncStartBattle(Battle b)
        {
            return Task.Run(() => {
                return b.StartBattle(players.First(), players.Last()); 
            });
            
        }
        private async Task<string> AsyncStartBattleSlow(Battle b)
        {
            await Task.Delay(500);
            return await AsyncStartBattle(b);
        }

        private void ProcessTextForResults(string ret)
        {
            var retArr = ret.Split(new string[] { "\n" }, StringSplitOptions.RemoveEmptyEntries);
            foreach (string s in retArr)
            {
                AddResultsToDisplay(s + "\n", s.Length + 1, TypeOfAlgin(s));
            }
        }

        private void AddResultsToDisplay(string s, int length, HorizontalAlignment align)
        {
            rtbResults.AppendText(s);
            rtbResults.Select(rtbResults.Text.Length - length, rtbResults.Text.Length);
            rtbResults.SelectionAlignment = align;
            rtbResults.ScrollToCaret();
        }

        private HorizontalAlignment TypeOfAlgin(string s)
        {
            if (s.Contains(players.Last().Name)) { return HorizontalAlignment.Right; }
            if (s.Contains("***WAR:")) { return HorizontalAlignment.Center; }
            return HorizontalAlignment.Left;
        }

        private bool IsThereAVictor(out int index)
        {
            index = 5;
            foreach (Player p in players)
            {
                if (p.PlayerCards.Count == 52)
                {
                    index = players.IndexOf(p);
                    return true;
                }
            }
            return false;
        }
        private void updateStats()
        {
            updatePlayerStats(players.First(), lblStats1);
            updatePlayerStats(players.Last(), lblStats2);
        }
        private void updatePlayerStats(Player player, Label label)
        {
            label.Text = String.Format($"cards:{player.PlayerCards.Count()} \r\nWarsWon:{player.WarsWon}\r\nWin Streak:{player.WinStreak}\r\nLongest Streak:{player.LongStreak}");
        }

    }
}
