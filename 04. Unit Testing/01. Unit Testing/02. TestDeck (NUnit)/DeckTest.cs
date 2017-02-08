namespace _02.TestDeck__NUnit_
{
    using NUnit.Framework;
    using Santase.Logic;
    using Santase.Logic.Cards;

    [TestFixture]
    public class DeckTest
    {
        [Test]
        public void GetNextCard_EmptyDeck_ThrowInternalGameException()
        {
            Deck deck = new Deck();

            Assert.Throws<InternalGameException>(() => deck.GetNextCard());
        }

    }
}
