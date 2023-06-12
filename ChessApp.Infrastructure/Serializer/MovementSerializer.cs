using Newtonsoft.Json;

using ChessApp.Core.Models;
using ChessApp.Core;

namespace ChessApp.Infrastructure.Serializer
{
    public class MovementSerializer : IMovementSerializer
    {

        public MovementSerializer()
        {
        }   

        public List<Movement> Deserialize(string source)
        {
            // Deserializar la cadena fuente en una lista de objetos Movement
            List<Movement> movement = JsonConvert.DeserializeObject<List<Movement>>(source);

            return movement;
        }
    }
}
