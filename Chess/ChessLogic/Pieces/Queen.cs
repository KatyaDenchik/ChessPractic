using ChessLogic.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessLogic.Pieces
{
    public class Queen : PieceBase
    {
        public override PieceTypeEnum Type => PieceTypeEnum.Queen;

        public override Player Color { get; }
        public Queen(Player color)
        {
            Color = color;
        }

        public override PieceBase Copy()
        {
            Queen copy = new Queen(Color);
            copy.HasMoved = HasMoved;
            return copy;
        }
    }
}
