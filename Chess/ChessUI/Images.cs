using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using ChessLogic;
using ChessLogic.Enums;
using ChessLogic.Pieces;

namespace ChessUI
{
    public static class Images
    {
        private static readonly Dictionary<PieceTypeEnum, ImageSource> whiteSources = new()
        {
            {PieceTypeEnum.Pawn, LoadImage("Assets/PawnW.png") },
            {PieceTypeEnum.Bishop, LoadImage("Assets/BishopW.png")},
            {PieceTypeEnum.Knight, LoadImage("Assets/KnightW.png")},
            {PieceTypeEnum.Rook, LoadImage("Assets/RookW.png")},
            {PieceTypeEnum.Queen, LoadImage("Assets/QueenW.png")},
            {PieceTypeEnum.King, LoadImage("Assets/KingW.png")},
        };
        private static readonly Dictionary<PieceTypeEnum, ImageSource> blackSources = new()
        {
            {PieceTypeEnum.Pawn, LoadImage("Assets/PawnB.png") },
            {PieceTypeEnum.Bishop, LoadImage("Assets/BishopB.png")},
            {PieceTypeEnum.Knight, LoadImage("Assets/KnightB.png")},
            {PieceTypeEnum.Rook, LoadImage("Assets/RookB.png")},
            {PieceTypeEnum.Queen, LoadImage("Assets/QueenB.png")},
            {PieceTypeEnum.King, LoadImage("Assets/KingB.png")},
        };

        public static ImageSource LoadImage(string filePath)
        {
            return new BitmapImage(new Uri(filePath, UriKind.RelativeOrAbsolute));
        }

        public static ImageSource GetImage(Player color, PieceTypeEnum type)
        {
            return color switch
            {
                Player.White => whiteSources[type],
                Player.Black => blackSources[type],
                _ => null
            };
        }

        public static ImageSource GetImage(PieceBase piece)
        {
            if (piece == null)
            {
                return null;
            }

            return GetImage(piece.Color, piece.Type);
        }

    }
}
