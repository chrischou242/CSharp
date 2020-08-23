using System;
using System.Collections.Generic;
namespace Deck_Of_Cards

{
    public class Deck
    {
        public List<Card> Cards;
        private string[] _suits;
        private string[] _faces;
        
        public Deck()
        {
            _suits = new string[]{"diamond", "club", "heart", "spade"};
            _faces = new string[] {"ace","two","three", "four","five","six", "seven","eight","nine", "ten","jack", "queen","king"};
            Reset();
            Shuffle();
        }

        private string suit(int card)
        {
            card = card/13;
            return _suits[card];
        }

        private string face(int card)
        {
            card = card%13;
            return _faces[card];
            
        }

        private int val( int card)
        {
            return (card%13)+1;
        }


        public Card RemoveCard()
        {
            Card TopCard= Cards[0];
            Cards.RemoveAt(0);
            return TopCard;
        }
        public void Reset()
        {  
            Cards = new List<Card>();
            for (int i=0; i<52 ;i++)
            {
                Card NewCard = new Card(face(i), suit(i), val(i));
                Console.WriteLine(NewCard);
                Cards.Add(NewCard);
            }

        }

        public List<Card> Shuffle ()
        {
            Random rand = new Random();
            for (int i = 0; i< Cards.Count*10 ; i++)
            {   
                int NextCard = rand.Next(Cards.Count);
                Card temp = Cards[NextCard];
                Cards[NextCard] = Cards[i];
                Cards[i] = temp;
            }
            return Cards;
        }




    }
}