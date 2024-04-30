using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessLogic.Enums
{
    public enum MoveType
    {
        Normal,
        CastleKS, //королевский фланг
        CastleQS, //ферзевый фланг
        DoublePawn, // пешка продвигается на две клетки
        EnPassant, // пешки можно захватить на Пуассоне
        PawnPromotion //можно передвинуть, если они доберутся до другого конца доски
    }
}
