using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_OOP
{
    public enum Status
    {
        Lose, Win
    }

    public class Game
    {
        public GameAccount opponent { get; }
        public string OpponentName { get; }
        public int currentRating { get; }
        public int GameIndex { get; }
        private Status status;
        public Status Status { get { return status; } }

        public Game(GameAccount opponent, int currentRating, int gameIndex, Status status)
        {
            this.opponent = opponent;
            this.currentRating = currentRating;
            this.GameIndex = gameIndex;
            this.status = status;
        }
        public Game(string Opponent, int currentRating, int gameIndex)
        {
            this.OpponentName = Opponent;
            this.currentRating = currentRating;
            this.GameIndex = gameIndex;
        }
    }
}
