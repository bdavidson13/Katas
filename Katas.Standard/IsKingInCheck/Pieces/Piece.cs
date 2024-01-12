using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Katas.Standard.IsKingInCheck.Pieces
{
    public class Piece
    {
        protected Space currentPostion;

        public Piece(Space position)
        {
            currentPostion = position;
        }

        public Space GetCurrentSquare()
        {
            return currentPostion;
        }
    }
}
