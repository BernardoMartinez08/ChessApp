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
    public class PieceFactory : IPieceFactory
    {
        public ChessPiece Create(ChessPieceType pieceType, ChessPieceColor color, ChessSquare currentPosition, ILogger logger)
        {
            try
            {
                var typeName = $"ChessApp.Core.ChessPieces.{pieceType}";
                var type = Type.GetType(typeName);

                if (type != null && typeof(ChessPiece).IsAssignableFrom(type))
                {
                    return (ChessPiece)Activator.CreateInstance(type, color, currentPosition, logger);
                }
            }
            catch (Exception ex)
            {
                logger.Log($"Error creating piece: {ex.Message}. Creating default ChessPiece.");
            }

            return new UnknownPiece(color, currentPosition, logger);
        }
    }

}
