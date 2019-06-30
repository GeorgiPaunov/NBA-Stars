namespace ReturnNBAStars
{
    class Player
    {
        public Player(string name, int playingSince, string position, int rating)
        {
            this.Name = name;
            this.PlayingSince = playingSince;
            this.Position = position;
            this.Rating = rating;
        }

        public string Name { get; set; }

        public int PlayingSince { get; set; }

        public string Position { get; set; }

        public int Rating { get; set; }
    }
}
