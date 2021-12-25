using System.Collections.Generic;
using System.Linq;

namespace KataTest.PokerHands
{
    public class PlayerCards
    {
        private readonly Dictionary<CardSuit, string> _cardSuit = new Dictionary<CardSuit, string>()
        {
            {CardSuit.C, "C"},
            {CardSuit.D, "D"},
            {CardSuit.H, "H"},
            {CardSuit.S, "S"}
        };

        private readonly Dictionary<string, int> _cardValue = new Dictionary<string, int>()
        {
            {"2", 2},
            {"3", 3},
            {"4", 4},
            {"5", 5},
            {"6", 6},
            {"7", 7},
            {"8", 8},
            {"9", 9},
            {"T", 10},
            {"J", 11},
            {"Q", 12},
            {"K", 13},
            {"A", 14},
        };

        private string _playerName;

        public PlayerCards(string name)
        {
            _playerName = name;
        }

        public void SetCards(string inputCards)
        {
            var cards = inputCards.Split(' ');
            var values = new List<string>();
            var suits = new List<CardSuit>();
            foreach (var card in cards)
            {
                var value = card.Substring(0, 1);
                var suit = card.Substring(1, 1);

                //Values.Add(cardValue.FirstOrDefault(x => x.Key == value).Value);
                suits.Add(_cardSuit.FirstOrDefault(x => x.Value == suit).Key);
            }
        }
    }
}