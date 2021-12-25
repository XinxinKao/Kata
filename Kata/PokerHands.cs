using System.Collections.Generic;
using System.Linq;

namespace Kata
{
    public static class PokerHands
    {
        public static string GetResult(PlayerCards player1, PlayerCards player2)
        {
            return string.Empty;
        }
    }

    public enum CardSuit
    {
        C = 0,
        D = 1,
        H = 2,
        S = 3
    }
    

    public class PlayerCards
    {
        public PlayerCards(string name)
        {
            PlayerName = name;
        }

        public string PlayerName { get; set; }
        public List<CardSuit> Suits { get; set; }
        public List<string> Values { get; set; }

        public void SetCards(string inputCards)
        {
            var cards = inputCards.Split(' ');
            Values = new List<string>();
            Suits = new List<CardSuit>();
            foreach (var card in cards)
            {
                var value = card.Substring(0, 1);
                var suit = card.Substring(1, 1);

                //Values.Add(cardValue.FirstOrDefault(x => x.Key == value).Value);
                Suits.Add(cardSuit.FirstOrDefault(x => x.Value == suit).Key);
                
            }
        }


        private readonly Dictionary<CardSuit, string> cardSuit = new Dictionary<CardSuit, string>()
        {
            {CardSuit.C,"C"},
            {CardSuit.D,"D"},
            {CardSuit.H,"H"},
            {CardSuit.S,"S"}
        };

        private readonly Dictionary<string, int> cardValue = new Dictionary<string, int>()
        {
            {"2",2},
            {"3",3},
            {"4",4},
            {"5",5},
            {"6",6},
            {"7",7},
            {"8",8},
            {"9",9},
            {"T",10},
            {"J",11},
            {"Q",12},
            {"K",13},
            {"A",14},
        };
    }
}