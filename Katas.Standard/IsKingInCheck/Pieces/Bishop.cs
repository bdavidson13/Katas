namespace Katas.Standard.IsKingInCheck.Pieces
{
    public class Bishop : Piece
    {
        public Bishop(Space position) : base(position)
        {
        }
        public void MoveDownLeft()
        {
            if (currentPostion.X != 0 && currentPostion.Y != 7)
            {
                currentPostion = new Space(currentPostion.X - 1, currentPostion.Y + 1);
            }
        }
        public void MoveUpRight()
        {
            if (currentPostion.X != 7 && currentPostion.Y != 0)
            {
                currentPostion = new Space(currentPostion.X + 1, currentPostion.Y - 1);
            }
        }

        public void MoveDownRight()
        {
            if (currentPostion.X != 7 && currentPostion.Y != 7)
            {
                currentPostion = new Space(currentPostion.X + 1, currentPostion.Y + 1);
            }
        }
        public void MoveUpLeft()
        {
            if (currentPostion.X != 0 && currentPostion.Y != 0)
            {
                currentPostion = new Space(currentPostion.X - 1, currentPostion.Y - 1);
            }
        }

    }
}
