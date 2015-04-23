namespace Roguelike
{
    public class Player
    {
        public int Row { get; private set; }
        public int Col { get; private set; }

        public Player(int row, int col)
        {
            this.Row = row;
            this.Col = col;
        }

        public void Move(int row, int col)
        {
            this.Row = row;
            this.Col = col;
        }

        public string ToString()
        {
            return "?";
        }

    }
}