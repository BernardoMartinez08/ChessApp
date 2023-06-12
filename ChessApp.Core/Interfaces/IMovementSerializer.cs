using ChessApp.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessApp.Core
{
    public interface IMovementSerializer
    {
        List<Movement> Deserialize(string source);
    }
}
