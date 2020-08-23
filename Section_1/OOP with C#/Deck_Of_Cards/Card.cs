namespace Deck_Of_Cards
{
    public class Card
    {
        public string StringVal {get;}
        public string Suit {get;}
        public int Val {get;}

        public Card(string stringVal , string suit , int val )
        {
            this.StringVal=stringVal;
            this.Suit = suit;
            this.Val = val;
        }
        public override string ToString()
        {
            return ($"{StringVal} {Suit} {Val} ");
        }
    }

    
}