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
    public class Pawn : ChessPiece, IMovementStrategy
    {
        public Pawn(ChessPieceColor color, ChessSquare currentPosition, ILogger logger)
            : base(color, currentPosition, logger)
        {
        }

        public override bool IsValidMove(ChessPiece chessPiece, ChessSquare targetSquare)
        {
            int columnDiff = Math.Abs(targetSquare.Column - chessPiece.CurrentPosition.Column);
            int rowDiff = Math.Abs(targetSquare.Row - chessPiece.CurrentPosition.Row);

            // Un movimiento válido para el peón depende del color de la pieza y la dirección del movimiento
            if (chessPiece.Color == ChessPieceColor.White)
            {
                // El peón blanco se mueve hacia arriba en el tablero
                return rowDiff == 1 && columnDiff == 0 && targetSquare.Row > chessPiece.CurrentPosition.Row;
            }
            else
            {
                // El peón negro se mueve hacia abajo en el tablero
                return rowDiff == 1 && columnDiff == 0 && targetSquare.Row < chessPiece.CurrentPosition.Row;
            }
        }
    }

}
