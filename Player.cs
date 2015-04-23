namespace Roguelike
{
    public class Player
    {
        private int _row = 0;
        private int _col = 0;

        public Player(int row, int col)
        {
            this._row = row;
            this._col = col;
        }

        public void Move(int row, int col)
        {
            this._row = row;
            this._col = col;
        }

        public string ToString()
        {
            return "?";
        }

    }
}