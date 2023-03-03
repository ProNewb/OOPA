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
        public List<Card> apack;



        //public Pack()

        public List<Card> pack = new List<Card>();

        public void deck()
        {
            //for (int i = 0; i<52; i++)
            //         pack.Add( new Card(i % 11, i / 13));

            for (int i = 0; i < 4; i++)
            {
                for (int j = 2; j < 15; j++)
                {
                    int suit = j;
                    int Val = i;
                    pack.Add(new Card(suit, Val));
                    //Console.WriteLine(pack.Count);
                }
            }
        }
        public void TestPack()
        {
            Console.WriteLine("Test to check contents of the deck object created" + "\n\n");
            foreach (Card c in pack)
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


        public static void shuffleType(List<Card> pack, int typeOfShuffle)
        {  
            if (typeOfShuffle == 1)
            {
                Card temp;
                // List<Card> pack;
                Random random = new Random();
                int n = 52;


                for (int i = 0; i < (n - 1); i++)
                {
                    int j = i + random.Next(n);
                    temp = pack[i];
                    pack[i] = pack[j];
                    pack[j] = temp;
                }



            }

        }

    }
}
  
