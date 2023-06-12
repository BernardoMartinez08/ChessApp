using ChessApp.Core;
using ChessApp.Core.Enums;
using ChessApp.Core.Interfaces;
using ChessApp.Core.Models;
using System;

namespace ChessApp.App
{
    public class ChessEngine
    {
        private readonly ILogger _logger;
        private readonly IMovementReader _movementReader;
        private readonly IMovementSerializer _movementSerializer;
        private readonly IPieceFactory _pieceFactory;

        public ChessEngine(ILogger logger, IMovementSerializer movementSerializer, IMovementReader movementReader, IPieceFactory pieceFactory)
        {
            _logger = logger;
            _movementReader = movementReader;
            _movementSerializer = movementSerializer;
            _pieceFactory = pieceFactory;
        }

        public void ValidateMovements()
        {
            _logger.Log("Starting movement validation.");

            _logger.Log("Loading movements.");

            // Load movements from file
            string movementsJson = _movementReader.Read();

            // Deserialize movements
            List<Movement> movements = _movementSerializer.Deserialize(movementsJson);            

            // Create pieces and validate movements
            int color = (int)ChessPieceColor.White;
            foreach (Movement movement in movements)
            {
                _logger.Log($"Validating movement: {movement.ToString()}");

                //Create piece
                var piece = _pieceFactory.Create(movement.PieceType, (ChessPieceColor)color, movement.SourceSquare, _logger);

                //Validate movement
                piece.OnMoveValidated(movement.TargetSquare);

                color = (color == (int)ChessPieceColor.White) ? (int)ChessPieceColor.Black : (int)ChessPieceColor.White;
            }

            _logger.Log("Movement validation completed.");
        }

    }

}
