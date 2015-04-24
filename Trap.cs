namespace Roguelike
{
    public class Trap
    {
        public int Row { get; private set; }
        public int Col { get; private set; }

        public Trap(int row, int col)
        {
            this.Row = row;
            this.Col = col;
        }

        public string ToString()
        {
            return ">";
        }
         
    }
}