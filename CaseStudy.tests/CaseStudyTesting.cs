using System;
using System.Collections.Generic;
using Xunit;

namespace CaseStudy.tests
{
    public class CaseStudyTesting
    {
    
        [Fact]
        public void TestSenaryo_12N_LMLMLMLMM()
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

            Assert.True(expectedOutput == actualOutput);
        }

        [Fact]
        public void TestSenaryo_33E_MRRMMRMRRM()
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

            Assert.True(expectedOutput==actualOutput);
        }
    }
}
