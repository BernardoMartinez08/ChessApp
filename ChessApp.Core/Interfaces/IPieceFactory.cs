using ChessApp.Core.ChessPieces;
using ChessApp.Core.Enums;
using ChessApp.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessApp.Core.Interfaces
{
    public interface IPieceFactory
    {
        ChessPiece Create(ChessPieceType pieceType, ChessPieceColor color, ChessSquare currentPosition, ILogger logger);
    }

}
