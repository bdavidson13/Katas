using Katas.Standard.IsKingInCheck.Pieces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Katas.Nunit.Test.IsKingInCheck
{
    public class BishopTests
    {

        public static object[] generateTestDataForDownLeft ={
            new object[]{ new Space(0, 0), new Space(0, 0) },
            new object[]{ new Space(1, 1), new Space(0, 2) },
            new object[]{ new Space(1, 0), new Space(0, 1) },
            new object[]{ new Space(0, 1), new Space(0, 1) },
            new object[]{ new Space(0, 3), new Space(0, 3) },
            new object[]{ new Space(7, 7), new Space(7, 7) }
            };

        public static object[] generateTestDataForUpRight ={
            new object[]{ new Space(0, 0), new Space(0, 0) },
            new object[]{ new Space(1, 1), new Space(2, 0) },
            new object[]{ new Space(1, 0), new Space(1, 0) },
            new object[]{ new Space(0, 1), new Space(1, 0) },
            new object[]{ new Space(7, 1), new Space(7, 1) }
            };

        public static object[] generateTestDataForDownRight ={
            new object[]{ new Space(0, 0), new Space(1,1) },
            new object[]{ new Space(1, 1), new Space(2, 2) },
            new object[]{ new Space(1, 0), new Space(2, 1) },
            new object[]{ new Space(0, 1), new Space(1, 2) },
            new object[]{ new Space(7, 1), new Space(7, 1) },
            new object[]{ new Space(1, 7), new Space(1, 7) }
            };

        public static object[] generateTestDataForUpLeft ={
            new object[]{ new Space(0, 0), new Space(0, 0) },
            new object[]{ new Space(1, 1), new Space(0, 0) },
            new object[]{ new Space(1, 0), new Space(1, 0) },
            new object[]{ new Space(0, 1), new Space(0, 1) },
            new object[]{ new Space(7, 1), new Space(6, 0) }
            };
        

        [Test]
        [TestCaseSource(nameof(generateTestDataForDownLeft))]
        public void MoveDownLeft(Space currentPosition, Space ExpecterResult)
        {
            //Arrange
            Bishop bishop = new Bishop(currentPosition);
            //Act
            bishop.MoveDownLeft();
            //Assert
            Assert.AreEqual(ExpecterResult.Y, bishop.GetCurrentSquare().Y, "Bad Y");
            Assert.AreEqual(ExpecterResult.X, bishop.GetCurrentSquare().X, "Bad x");
        }

        [Test]
        [TestCaseSource(nameof(generateTestDataForUpRight))]
        public void MoveUpRight(Space currentPosition, Space ExpecterResult)
        {
            //Arrange
            Bishop bishop = new Bishop(currentPosition);
            //Act
            bishop.MoveUpRight();
            //Assert
            Assert.AreEqual(ExpecterResult.Y, bishop.GetCurrentSquare().Y, "Bad Y");
            Assert.AreEqual(ExpecterResult.X, bishop.GetCurrentSquare().X, "Bad x");
        }

        [Test]
        [TestCaseSource(nameof(generateTestDataForDownRight))]
        public void MoveDownRight(Space currentPosition, Space ExpecterResult)
        {
            //Arrange
            Bishop bishop = new Bishop(currentPosition);
            //Act
            bishop.MoveDownRight();
            //Assert
            Assert.AreEqual(ExpecterResult.Y, bishop.GetCurrentSquare().Y, "Bad Y");
            Assert.AreEqual(ExpecterResult.X, bishop.GetCurrentSquare().X, "Bad x");
        }

        [Test]
        [TestCaseSource(nameof(generateTestDataForUpLeft))]
        public void MoveUpLeft(Space currentPosition, Space ExpecterResult)
        {
            //Arrange
            Bishop bishop = new Bishop(currentPosition);
            //Act
            bishop.MoveUpLeft();
            //Assert
            Assert.AreEqual(ExpecterResult.Y, bishop.GetCurrentSquare().Y, "Bad Y");
            Assert.AreEqual(ExpecterResult.X, bishop.GetCurrentSquare().X, "Bad x");
        }
    }
}
