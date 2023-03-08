using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace acard
{
    internal class Pack
    {
        public List<Card> apack;



        //public Pack()

        List<Card> pack = new List<Card>();

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
                Console.Write(" " + c.aface + "\t"+ "\t" +"\t"+ "\t");
               // Console.WriteLine("\n");
            }
            Console.WriteLine("\n\n");    
        }

       // public static bool shuffleCardPack(int typeOfShuffle)
        //{ 
        
        
        //}

        // Marcus Sanghvi (26944375) - Peer Review
        // Code is functional and prints out a pack of cards with all correct values (e.g 1 of Hearts)
        // The spacing of the string values for cards in the command terminal could be organized better (e.g all in line)
        // Some errors are handled when asking for which type of shuffle, however the error is only handled on the first instance then the program is closed.
        // To improve I suggest a loop that keeps asking for input until the correct conditions are satisfied, or simply recall the main function.
        // Add at least 1 shuffle function would be the best way to improve this code in my opinion.

    }
}  
