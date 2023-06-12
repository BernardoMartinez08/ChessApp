using ChessApp.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessApp.Core.Models
{
    public class Movement
    {
        public ChessPieceType PieceType { get; set; }
        public ChessSquare SourceSquare { get; set; }
        public ChessSquare TargetSquare { get; set; }
    }
}
