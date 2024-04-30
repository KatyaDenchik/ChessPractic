using ChessLogic.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessLogic.Pieces
{
    public class Knight : PieceBase
    {
        public override PieceTypeEnum Type => PieceTypeEnum.Knight;
        public override Player Color { get; }
        public Knight(Player color) 
        { 
            Color = color;
        }

        public override PieceBase Copy()
        {
            Knight copy = new Knight(Color);
            copy.HasMoved = HasMoved;
            return copy;
        }
    }
}
