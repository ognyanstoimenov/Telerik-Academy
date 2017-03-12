using Moq;
using NUnit.Framework;

namespace Poker.Tests
{
    [TestFixture]
    public class CardTests
    {
        [Test]
        public void ToStringShould_ReturnCorrectString()
        {
            var testSuit = CardSuit.Spades;
            var testFace = CardFace.Jack;

            var card = new Card(testFace,testSuit);

            Assert.AreEqual("Jack of Spades", card.ToString());
        }
    }
}
