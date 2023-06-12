using ChessApp.Core.ChessPieces;
using ChessApp.Core.Models;

namespace ChessApp.Core.Interfaces
{
    public interface IObserver
    {
        void OnMoveValidated(ChessPiece piece, ChessSquare targetSquare);
    }
}
