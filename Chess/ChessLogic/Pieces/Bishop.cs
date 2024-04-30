﻿using ChessLogic.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessLogic.Pieces
{
    public class Bishop : PieceBase
    {
        public override PieceTypeEnum Type => PieceTypeEnum.Bishop;
        public override Player Color { get; }
        public Bishop(Player color) 
        {
            Color = color;
        }

        public override PieceBase Copy()
        {
            Bishop copy = new Bishop(Color);
            copy.HasMoved = HasMoved;
            return copy;
        }
    }
}
