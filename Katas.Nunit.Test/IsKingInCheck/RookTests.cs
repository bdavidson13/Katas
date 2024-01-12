using Katas.Standard.IsKingInCheck.Pieces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Katas.Nunit.Test.IsKingInCheck
{
    public class RookTests
    {
        [Test]
        public void GivenRookIsInTheMiddleOfTheBoardRookCanMoveForwardOneSpace()
        {
            //Arrange
            Rook rook = new Rook(new Space(5, 5));
            Space expectedSpace = new Space(5, 6);
            //Act
            rook.MoveForward();
            //Assert
            Assert.AreEqual(expectedSpace.Y, rook.GetCurrentSquare().Y);
            Assert.AreEqual(expectedSpace.X, rook.GetCurrentSquare().X);
        }
        [Test]
        public void GivenRookIsInTheMiddleOfTheBoardRookCanMoveBackwardOneSpace()
        {
            //Arrange
            Rook rook = new Rook(new Space(5, 5));
            Space expectedSpace = new Space(5, 4);
            //Act
            rook.MoveBack();
            //Assert
            Assert.AreEqual(expectedSpace.Y, rook.GetCurrentSquare().Y);
            Assert.AreEqual(expectedSpace.X, rook.GetCurrentSquare().X);
        }
        [Test]
        public void GivenRookIsInTheMiddleOfTheBoardRookCanMoveRightOneSpace()
        {
            //Arrange
            Rook rook = new Rook(new Space(5, 5));
            Space expectedSpace = new Space(6, 5);
            //Act
            rook.MoveRight();
            //Assert
            Assert.AreEqual(expectedSpace.Y, rook.GetCurrentSquare().Y);
            Assert.AreEqual(expectedSpace.X, rook.GetCurrentSquare().X);
        }
        [Test]
        public void GivenRookIsInTheMiddleOfTheBoardRookCanMoveLeftOneSpace()
        {
            //Arrange
            Rook rook = new Rook(new Space(5, 5));
            Space expectedSpace = new Space(4, 5);
            //Act
            rook.MoveLeft();
            //Assert
            Assert.AreEqual(expectedSpace.Y, rook.GetCurrentSquare().Y);
            Assert.AreEqual(expectedSpace.X, rook.GetCurrentSquare().X);
        }
        [Test]
        public void GivenRookIsOnTopRankMovingUpDoesnotChangeCurrentPosition()
        {
            //Arrange
            Rook rook = new Rook(new Space(1, 7));
            Space expectedSpace = new Space(1, 7);
            //Act
            rook.MoveForward();
            //Assert
            Assert.AreEqual(expectedSpace.Y, rook.GetCurrentSquare().Y);
            Assert.AreEqual(expectedSpace.X, rook.GetCurrentSquare().X);
        }
        [Test]
        public void GivenRookIsOnBottomRankMovingDownDoesnotChangeCurrentPosition()
        {
            //Arrange
            Rook rook = new Rook(new Space(1, 0));
            Space expectedSpace = new Space(1, 0);
            //Act
            rook.MoveBack();
            //Assert
            Assert.AreEqual(expectedSpace.Y, rook.GetCurrentSquare().Y);
            Assert.AreEqual(expectedSpace.X, rook.GetCurrentSquare().X);
        }
        [Test]
        public void GivenRookIsOnTopLeftCornerMovingLeftDoesnotChangeCurrentPosition()
        {
            //Arrange
            Rook rook = new Rook(new Space(0, 0));
            Space expectedSpace = new Space(0, 0);
            //Act
            rook.MoveLeft();
            //Assert
            Assert.AreEqual(expectedSpace.Y, rook.GetCurrentSquare().Y);
            Assert.AreEqual(expectedSpace.X, rook.GetCurrentSquare().X);
        }
        [Test]
        public void GivenRookIsOnTopRightCornerMovingLeftDoesnotChangeCurrentPosition()
        {
            //Arrange
            Rook rook = new Rook(new Space(7,0));
            Space expectedSpace = new Space(7, 0);
            //Act
            rook.MoveRight();
            //Assert
            Assert.AreEqual(expectedSpace.Y, rook.GetCurrentSquare().Y);
            Assert.AreEqual(expectedSpace.X, rook.GetCurrentSquare().X);
        }
    }
}
