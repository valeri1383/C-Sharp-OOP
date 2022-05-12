using System;

namespace Players_and_Monsters_Inheritance
{
    public abstract class Hero
    {
        private const int MIN_LVL = 0;

        private string username;
        private int lvl;

        public Hero(string username, int lvl)
        {
            this.Username = username;
            this.Lvl = lvl;
        }

        public string Username
        {
            get 
            {
                return this.username;
            }
            private set 
            {
                this.username = value;
            }
        }

        public int Lvl
        {
            get
            {
                return this.lvl;
            }
            private set
            {
                if (value < MIN_LVL)
                {
                    throw new ArgumentException("Level cannot be negative number!");
                }

                this.lvl = value;
            }
        }

        public override string ToString()
        {
            return $"Type: {this.GetType().Name} Username: {this.Username} Level: {this.lvl}";
        }

    }
}
