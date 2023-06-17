using ChessApp.Core;
using ChessApp.Core.ChessPieces;
using ChessApp.Infrastructure.Loggers;
using ChessApp.Infrastructure.Readers;
using ChessApp.Infrastructure.Serializer;

Console.WriteLine("Chess Movements Validation System Starting...");

var engine = new ChessEngine(
    new ConsoleLogger(),
    new MovementSerializer(),
    new FileMovementsReader(),
    new PieceFactory()
);

engine.ValidateMovements();

