namespace Ex4{
    class Team{
        public string Name { get; set; }
        public string Coach { get; set; }
        public string ConsolePrint { get; set; } // Переменная для вывода ToString
        public List<Player> Players { get; set; } = new List<Player>();
        public void NewPlayers(Player Gamer) {
            Players.Add(Gamer);
        }
        public override string ToString(){
            foreach (Players Gamer in this.Players) {
                ConsolePrint = ConsolePrint + " " + Gamer.Name;
            }
            return ConsolePrint;
        }
    }
    
    class Player{
        public int Number { get; set; }
        public string Name { get; set; }
        public Team Team { get; set; }
        public Player() {}
        public Player(int _number, string _name) {
            this.Number = _number;
            this.Name = _name;
        }
        public override string ToString(){
            return $"Player number - {number}; name - {Name}.";
        }
    }
}