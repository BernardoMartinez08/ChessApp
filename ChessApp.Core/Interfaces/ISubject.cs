using ChessApp.Core.ChessPieces;
using ChessApp.Core.Models;

namespace ChessApp.Core.Interfaces
{
    public interface ISubject
    {
        void AddObserver(IObserver observer);
        void RemoveObserver(IObserver observer);
        void NotifyMoveValidated(ChessPiece piece, ChessSquare targetSquare);
    }
}

