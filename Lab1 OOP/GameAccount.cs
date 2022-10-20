using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_OOP
{
    public class GameAccount
    {
        public string UserName;
        public string OpponentName;
        public int CurrentRating;
        public int GamesCount;
        public int GameIndex;
        private List<Game> allStatistics;

        public GameAccount(string userName, string opponentName)
        {
            UserName = userName;
            CurrentRating = 1000;
            GamesCount = 0;
            allStatistics = new List<Game>();
            OpponentName = opponentName;
        }

        public void WinGame(GameAccount opponent)
        {
            CurrentRating += 20;
            GameIndex++;
            if (CurrentRating <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(CurrentRating), "Amount of rating must be positive");
            }
            var win = new Game(opponent, CurrentRating, GameIndex, Status.Win);
            allStatistics.Add(win);
        }

        public void LoseGame(GameAccount opponent)
        {
            GameIndex++;
            if (CurrentRating - 20 <= 0)
            {
                CurrentRating = 1;
            }
            else CurrentRating -= 20;
            if (CurrentRating <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(CurrentRating), "Amount of rating must be positive");
            }
            var lose = new Game(opponent, CurrentRating, GameIndex, Status.Lose);
            allStatistics.Add(lose);
        }

        public void CreateAccount(string opponent)
        {
            GameIndex = 0;
            var created = new Game(opponent, CurrentRating, GameIndex);
            allStatistics.Add(created);
        }

        public string GetAccountHistory()
        {
            var report = new System.Text.StringBuilder();

            report.AppendLine("Opponent Name\tStatus\tRating\tGame index");
            foreach (var item in allStatistics)
            {
                report.AppendLine($"{OpponentName}\t\t{item.Status}\t{item.currentRating}\t{item.GameIndex}");
            }

            return report.ToString();
        }
    }
}
