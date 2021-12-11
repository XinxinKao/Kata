using Kata;
using NUnit.Framework;

namespace KataTest
{
    [TestFixture]
    public class PokerHandsTest
    {
        [TestCase("2H 3D 5S 9C KD", "2C 3H 4S 8C AH", "", TestName = "White Win with high card Ace")]
        public void Test(string blackInput, string whiteInput, string output)
        {
            var player1 = new PlayerCards("Black");
            player1.SetCards(blackInput);
            var player2 = new PlayerCards("White");
            player2.SetCards(whiteInput);
            var actual = PokerHands.GetResult(player1, player2);
            var expected = output;
            Assert.AreEqual(expected, actual);
        }

    }
}