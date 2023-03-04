using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace acard
{
    internal class Pack
    {
        //public List<Card> pack;
        public int typeOfShuffle;
        //public static List<Card> playerHand;

        //public Pack()

        public List<Card> pack = new List<Card>();
        public static List<Card> playerHand = new List<Card>();
        public static List<Card> shuffledPack = new List<Card>();
        public void deck(Pack pack)
        {
            //for (int i = 0; i<52; i++)
            //         pack.Add( new Card(i % 11, i / 13));

            for (int i = 0; i < 4; i++)
            {
                for (int j = 2; j < 15; j++)
                {
                    int suit = j;
                    int Val = i;
                    pack.pack.Add(new Card(suit, Val));
                    //Console.WriteLine(pack.Count);
                }
            }
        }
        public void TestPack(Pack pack)
        {
            Console.WriteLine("Test to check contents of the deck object created" + "\n\n");
            foreach (Card c in pack.pack)
            {
                Console.Write(" " + c.aface + "\t" + "\t" + "\t" + "\t");
                // Console.WriteLine("\n");
            }
            Console.WriteLine("\n\n");
        }
        public static bool ShuffleCardPack(int typeOfShuffle)
        {
            if (typeOfShuffle == 1)
            { return true; }
            else if (typeOfShuffle == 2)
            { return true; }
            else if (typeOfShuffle == 3)
            { return true; }
            return true;
        }


        public void shuffleType(int typeOfShuffle)
        { }
           // if ()};

             public void fisher(Pack pack)
                {
                    Card temp;
            Card temp2;

                    Random random = new Random();
                    int n = 51;
            // Pack shuffledPack = new Pack();

            for (int i = 0; i < 1; i++)

                foreach (Card c in pack.pack)
                {
                    // int j = random.Next(n - 1);
                    int k = random.Next(n - 1);
                    temp = pack.pack[k];
                    // temp2 = pack.pack[j];

                    //pack.pack[k] = pack.pack[j];

                    shuffledPack.Insert(0, temp);


                    //Console.WriteLine(pack.pack[0].value);

                }
                    foreach (Card d in shuffledPack)
                    {

                        Console.WriteLine(d.aface);
                    }
                }
            
                

        public static Card deal(Pack pack)
        {
            //Deals one card
            Card card;
            card = pack.pack[0];
            Console.WriteLine(card.aface);
            return card;
        }
        public static List<Card> dealCard(int amount, Pack pack)
        {
            ; //Deals the number of cards specified by 'amount'

            int Ind = 0;
            for (int i = 0; i < amount; i++)
            {
                //pack.pack[i].ToList();
                Pack.playerHand.Add(pack.pack[Ind]);
                Console.WriteLine(Pack.playerHand[Ind].aface);
                Ind++;

            }
            return playerHand;
           
            
            /* Ind = 0;
                foreach (Card c in playerHand) { 
                Console.WriteLine(Pack.playerHand[Ind].aface);
                //pack.pack.Remove(pack.pack[0]);
                Ind++;
            }*/ 
        
        
        }

    }

        }

    
  
