using ChessApp.Core.ChessPieces;
using ChessApp.Core.Interfaces;

namespace ChessApp.Core.Models
{
    public class ChessBoard : ISubject
    {
        private List<IObserver> observers;

        public ChessBoard()
        {
            observers = new List<IObserver>();
        }

        public void AddObserver(IObserver observer)
        {
            observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            observers.Remove(observer);
        }

        public void NotifyMoveValidated(ChessPiece piece, ChessSquare targetSquare)
        {
            foreach (var observer in observers)
            {
                observer.OnMoveValidated(piece, targetSquare);
            }
        }
    }

}
