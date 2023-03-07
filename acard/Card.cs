
///OOP assignment 1///
//Class to create a card object
namespace CMP1903M_A01_2223
{
    internal class Card
    {
        public int suit { get; set; }
        public int value { get; set; }

        public string faceVal;

        public string faceSuit;


        public string aface;
        public Card(int value, int suit)
        {
            this.value = value + 1;
            this.suit = suit;

            faceVal = value.ToString();
            faceSuit = suit.ToString();

            //Non numerical cards and suit settings
            if (suit == 0)
            { faceSuit = "Hearts"; }

            if (suit == 1)
            { faceSuit = "Spades"; }

            if (suit == 2)
            { faceSuit = "Diamonds"; }


            if (suit == 3)
            { faceSuit = "Clubs"; }





            switch (faceVal)
            // faceVal = faceVal switch
            {
                case "14":
                    faceVal = "Ace";
                    break;

                case "13":
                    faceVal = "King";
                    break;
                case "12":
                    faceVal = "Queen";
                    break;
                case "11":
                    faceVal = "Jack";
                    break;
                default:
                    faceVal = value.ToString();
                    break;
            }
            aface = faceVal + " of " + faceSuit;

        }


    }


}

