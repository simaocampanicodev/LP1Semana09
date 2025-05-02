using System;

namespace PlayerManager3
{
    public class Player : IComparable
    {
        
        public string Name { get; }
        public int Score { get; set; }

        public Player(string name, int score)
        {
            Name = name;
            Score = score;
        }

        public int CompareTo(object obj)
        {
            if (obj == null || !(obj is Player other)) return 1;
            return other.Score - this.Score;
        }
        
    }
}