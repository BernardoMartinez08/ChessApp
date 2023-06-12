using ChessApp.Core.Interfaces;

namespace ChessApp.Infrastructure.Readers;
public class FileMovementsReader : IMovementReader
{
    public string Read() => File.ReadAllText("moves.json");
}