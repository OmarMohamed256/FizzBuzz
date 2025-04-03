using NUnit.Framework;
using NUnit.Framework.Legacy;

namespace FizzBuzzTests
{
    [TestFixture]
    public class FizzBuzzDetectorTests
    {
        [Test]
        public void GetOverlappings_WhenInputIsNull_ThrowsArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => FizzBuzzDetector.GetOverlappings(null));
        }
        [Test]
        public void IsAlphanumeric_WhenWordIsAlphanumeric_ReturnsTrue()
        {
            ClassicAssert.IsTrue(FizzBuzzDetector.IsAlphanumeric("word"));
        }
        [Test]
        public void IsAlphanumeric_WhenWordIsNotAlphanumeric_ReturnsFalse()
        {
            Assert.That(FizzBuzzDetector.IsAlphanumeric("!@#$%^"), Is.False);
        }

        [Test]
        public void GetOverlappings_WhenInputContainsMultiplesOf3_FizzCountIsCorrect()
        {
            string input = "one two three four five six seven eight nine";

            var result = FizzBuzzDetector.GetOverlappings(input);

            Assert.That(result.FizzCount, Is.EqualTo(3));
        }

        [Test]
        public void GetOverlappings_WhenInputContainsMultiplesOf5_BuzzCountIsCorrect()
        {
            string input = "one two three four five six seven eight nine ten";

            var result = FizzBuzzDetector.GetOverlappings(input);

            Assert.That(result.BuzzCount, Is.EqualTo(2));
        }
        [Test]
        public void GetOverlappings_WhenInputContainsMultiplesOf15_FizzBuzzCountIsCorrect()
        {
            string input = "one two three four five six seven eight nine ten eleven twelve thirteen fourteen fifteen sixteen seventeen eighteen nineteen twenty twenty-one twenty-two twenty-three twenty-four twenty-five twenty-five twenty-five twenty-five twenty-five thirty";

            var result = FizzBuzzDetector.GetOverlappings(input);

            Assert.That(result.FizzBuzzCount, Is.EqualTo(2));
        }
    }
}
