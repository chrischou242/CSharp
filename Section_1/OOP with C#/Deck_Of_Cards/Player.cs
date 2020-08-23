using System;
using System.Collections.Generic;
namespace Deck_Of_Cards
{
    public class Player
    {
        public string Name{get;}
        public List<Card> Hand{get;}

        public Player(string name)
        {
            this.Name = name;
            this.Hand = new List<Card>();
           
        }
        public Card Draw(Deck cards)
        {
           Card NextDraw = cards.RemoveCard();
           Hand.Add(NextDraw);
           return NextDraw; 
        }    

        public Card Discard(int card)
        {
            if (card >=0 && card<Hand.Count)
            {
                Card RemoveCard = Hand[card];
                Hand.RemoveAt(card);
                return RemoveCard;
            }
            else{
                return null;
            }
             
        }
    }
}