

namespace MicrosoftInterview
{
    public class TicTacToe
    {
        private int[]Rows { get; set; }
        private int[] Columns { get; set; }
        private int Diagonal { get; set; }

        private int GridSize { get; set; }

        private int AntiDiagonal { get; set; }
        public TicTacToe(int n)
        {
            Rows = new int[n];
            Columns = new int[n];
            GridSize = n;
        }

        public int Move(int row, int col, int player)
        {
            int currentPlayer = player == 1 ? 1 : -1;

            Rows[row] += currentPlayer;
            Columns[col] += currentPlayer;

            if (row == col)
                Diagonal += currentPlayer;

            if (row + col == GridSize - 1)
                AntiDiagonal += currentPlayer;

            if (Math.Abs(Diagonal) == GridSize || Math.Abs(AntiDiagonal) == GridSize
                || Math.Abs(Rows[row]) == GridSize || Math.Abs(Columns[col]) == GridSize )
            {
                return currentPlayer;
            }

            return 0;
        }
    }

}
