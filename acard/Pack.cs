using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    class Pack
    {



        public List<Card> pack = new List<Card>();
        public static List<Card> playerHand = new List<Card>();
        public static List<Card> shuffledPack = new List<Card>();

        //main constructor
        public Pack()
        {


            for (int i = 0; i < 4; i++)
            {
                for (int j = 2; j < 15; j++)
                {
                    int suit = j;
                    int Val = i;
                    pack.Add(new Card(suit, Val));

                }
            }
        }
        //Testing
        public void TestPack(Pack pack)
        {

            foreach (Card c in pack.pack)
            {
                Console.Write(" " + c.aface + "\t" + "\t" + "\t" + "\t");

            }
            Console.WriteLine("\n\n");
        }

        //Descide which shuffle to perform and validate input
        public static bool ShuffleCardPack(in int typeOfShuffle)
        {
            if (typeOfShuffle != 1 || typeOfShuffle != 2 || typeOfShuffle != 3)
            {
                return false;
            }
            else { Environment.Exit(1); return true; }
        }



        //Shuffle specifics

        public void fisher(Pack pack)
        {


            Card temp;


            Random random = new Random();
            int n = 51;


            for (int i = 0; i < n; i++)

            // foreach (Card c in pack.pack)
            {

                int k = random.Next(n - 1);
                temp = pack.pack[i];
                pack.pack[i] = pack.pack[k];
                pack.pack[k] = temp;




            }
            foreach (Card d in pack.pack)
            {

                Console.WriteLine(d.aface);
            }
        }


        public void riffle(Pack pack)
        {

            List<Card> TempPackA = new List<Card>();
            List<Card> TempPackB = new List<Card>();

            for (int i = 0; i < 26; i++)
                TempPackA.Add(pack.pack[i]);

            for (int i = 26; i < 52; i++)
                TempPackB.Add(pack.pack[i]);
            pack.pack.Clear();
            for (int i = 0; i < 52; i++)
            {
                Random random = new Random();
                Random rIndex = new Random();
                int rDex = rIndex.Next(0, 26);
                int rNum = random.Next(0, 26);
                pack.pack.Add(TempPackA[rDex]);
                pack.pack.Add(TempPackB[rNum]);
            }


            foreach (Card d in pack.pack)
            {
                Console.WriteLine(d.aface);
            }

        }

        //Dealing methods
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
            //Deals the number of cards specified by 'amount'

            int Ind = 0;
            for (int i = 0; i < amount; i++)
            {

                playerHand.Add(pack.pack[Ind]);
                Console.WriteLine(playerHand[Ind].aface);
                Ind++;

            }
            return playerHand;
        }
    }
}           
            
     
        
        
   

    
  
