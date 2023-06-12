using ChessApp.Core.Enums;
using ChessApp.Core.Interfaces;
using ChessApp.Core.Models;

namespace ChessApp.Core.ChessPieces
{
    public abstract class ChessPiece
    {
        public ChessPieceColor Color { get; protected set; }
        public ChessSquare CurrentPosition { get; set; }
        public ILogger Logger { get; set; }

        public ChessPiece(ChessPieceColor color, ChessSquare currentPosition, ILogger logger)
        {
            Color = color;
            CurrentPosition = currentPosition;
            Logger = logger;
        }

        public void OnMoveValidated(ChessSquare targetSquare)
        {
            string pieceName = GetType().Name;
            string currentPosition = CurrentPosition.ToString();
            string targetPosition = targetSquare.ToString();

            string moveDescription = $"Movimiento: {pieceName} de {currentPosition} a {targetPosition}";

            if (IsValidMove(this, targetSquare))
            {
                Logger.Log($"{moveDescription}\nEs válido!");
            }
            else
            {
                Logger.Log($"{moveDescription}\nEs inválido!");
            }
        }

        public abstract bool IsValidMove(ChessPiece chessPiece, ChessSquare targetSquare);
    }
}

