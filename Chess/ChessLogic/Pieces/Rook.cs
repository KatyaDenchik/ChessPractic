using ChessLogic.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessLogic.Pieces
{
    public class Rook : PiecesBase
    {
        public override PieceTypeEnum Type => PieceTypeEnum.Rook;

        public override Player Color { get; }
        public Rook(Player color)
        {
            Color = color;
        }

        public override PiecesBase Copy()
        {
            Rook copy = new Rook(Color);
            copy.HasMoved = HasMoved;
            return copy;
        }
    }
}
