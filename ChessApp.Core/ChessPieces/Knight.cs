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
    public class Knight : ChessPiece, IMovementStrategy
    {
        public Knight(ChessPieceColor color, ChessSquare currentPosition, ILogger logger)
            : base(color, currentPosition, logger)
        {
        }

        public override bool IsValidMove(ChessPiece chessPiece, ChessSquare targetSquare)
        {
            int columnDiff = Math.Abs(targetSquare.Column - chessPiece.CurrentPosition.Column);
            int rowDiff = Math.Abs(targetSquare.Row - chessPiece.CurrentPosition.Row);

            // Un movimiento válido para el caballo es cuando se mueve en forma de "L"
            return (columnDiff == 2 && rowDiff == 1) || (columnDiff == 1 && rowDiff == 2);
        }
    }
}

