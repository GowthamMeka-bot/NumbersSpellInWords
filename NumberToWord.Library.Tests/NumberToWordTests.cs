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
            SpellNumberToWord spellObject = new SpellNumberToWord();
            // Act
            string output = spellObject.SpellTheNumber(input);
            // Assert
            Assert.AreEqual("fifty five",output);
        }

        [Test]
        public void Should_Return_WarningMessage_When_NegitiveInteger_IsPassed()
        {
            // Arrange
            int input = -100;
            SpellNumberToWord spellObject = new SpellNumberToWord();
            // Act
            string output = spellObject.SpellTheNumber(input);
            // Assert
            Assert.AreEqual("Please enter positive Number", output);
        }
    }
}
