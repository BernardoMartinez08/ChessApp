using ChessApp.Core.ChessPieces;
using ChessApp.Core.Models;

namespace ChessApp.Core.Interfaces
{
    public interface IMovementStrategy
    {
        bool IsValidMove(ChessPiece chessPiece, ChessSquare targetSquare);
    }
}
