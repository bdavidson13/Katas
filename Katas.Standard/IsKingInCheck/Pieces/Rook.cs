using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Katas.Standard.IsKingInCheck.Pieces
{
    public class Rook : Piece
    {
        public Rook(Space position) : base(position)
        {
        }
        public void MoveForward()
        {
            if (currentPostion.Y + 1 < 7)
            {
                currentPostion = new Space(currentPostion.X, currentPostion.Y + 1);
            }
        }
        public void MoveBack()
        {
            if (currentPostion.Y - 1 > 0)
            {
                currentPostion = new Space(currentPostion.X, currentPostion.Y - 1);
            }
        }
        public void MoveRight()
        {
            if (currentPostion.X + 1 < 7)
            {
                currentPostion = new Space(currentPostion.X + 1, currentPostion.Y);
            }
        }
        public void MoveLeft()
        {
            if (currentPostion.X - 1 > 0)
            {
                currentPostion = new Space(currentPostion.X - 1, currentPostion.Y);
            }
        }
    }
}
