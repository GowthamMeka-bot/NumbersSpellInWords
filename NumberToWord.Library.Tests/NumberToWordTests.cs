using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberToWord.Library.Tests
{
    [TestFixture]
    public class NumberToWordTests
    {
        [Test]
        public void Should_Return_FiftyFive_When_55()
        {
            // Arrange
            int input = 55;
            // Act
            string output = SpellNumberToWord.SpellTheNumber(input);
            // Assert
            Assert.AreEqual("fifty five",output);
        }
    }
}
