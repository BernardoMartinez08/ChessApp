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
    public class UnknownPiece : ChessPiece
    {
        public UnknownPiece(ChessPieceColor color, ChessSquare currentPosition, ILogger logger)
            : base(color, currentPosition, logger)
        {
        }

        public override bool IsValidMove(ChessPiece piece, ChessSquare targetSquare)
        {
            // La pieza desconocida no puede moverse, por lo que siempre devuelve false.
            return false;
        }
    }

}
