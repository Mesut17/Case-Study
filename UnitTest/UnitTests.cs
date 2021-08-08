using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void TestScanrio_12N_LMLMLMLMM()
        {

            var x = 1;
            var y = 2;
            var direction = Directions.N;
            var maxPoints = new List<int>() { 5, 5 };
            Position position = new Position(x, y, direction, maxPoints);

            var moves = "LMLMLMLMM";

            position.StartMoving(moves);

            var actualOutput = $"{position.X} {position.Y} {position.Direction.ToString()}";
            var expectedOutput = "1 3 N";

            Assert.AreEqual(expectedOutput, actualOutput);
        }

        [TestMethod]
        public void TestScanrio_33E_MRRMMRMRRM()
        {
            var x = 3;
            var y = 3;
            var direction = Directions.E;
            var maxPoints = new List<int>() { 5, 5 };
            Position position = new Position(x, y, direction, maxPoints);

            var moves = "MRRMMRMRRM";

            position.StartMoving(moves);

            var actualOutput = $"{position.X} {position.Y} {position.Direction.ToString()}";
            var expectedOutput = "2 3 S";

            Assert.AreEqual(expectedOutput, actualOutput);
        }
    }
}
