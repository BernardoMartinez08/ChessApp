using ChessApp.Core.Enums;
using ChessApp.Core.Interfaces;
using ChessApp.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessApp.Core.ChessPieces
{
    public class Rook : ChessPiece, IMovementStrategy
    {
        public Rook(ChessPieceColor color, ChessSquare currentPosition, ILogger logger)
            : base(color, currentPosition, logger)
        {
        }

        public override bool IsValidMove(ChessPiece chessPiece, ChessSquare targetSquare)
        {
            int columnDiff = Math.Abs(targetSquare.Column - chessPiece.CurrentPosition.Column);
            int rowDiff = Math.Abs(targetSquare.Row - chessPiece.CurrentPosition.Row);

            // Un movimiento válido para la torre es cuando se mueve en línea recta en la misma columna o fila
            return columnDiff == 0 || rowDiff == 0;
        }
    }

}
