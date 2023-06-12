
namespace ChessApp.Core.Models
{
    public class ChessSquare
    {
        public char Column { get; }
        public int Row { get; }

        public ChessSquare(char column, int row)
        {
            Column = column;
            Row = row;
        }

        public static bool TryParse(string value, out ChessSquare chessSquare)
        {
            chessSquare = null;

            if (string.IsNullOrEmpty(value) || value.Length != 2)
            {
                return false;
            }

            char fileChar = value[0];
            char rankChar = value[1];

            if (!char.IsLetter(fileChar) || !char.IsDigit(rankChar))
            {
                return false;
            }

            int file = fileChar - 'a';
            int rank = rankChar - '1';

            if (file < 0 || file >= 8 || rank < 0 || rank >= 8)
            {
                return false;
            }

            chessSquare = new ChessSquare((char)file, rank);
            return true;
        }

    }
}
