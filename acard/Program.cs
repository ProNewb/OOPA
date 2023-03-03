

using System.Reflection.Metadata.Ecma335;
namespace acard
{
    class Program
    {
        static void Main(string[] args)
        {
            Card testCard = new Card(2, 1);

            Console.WriteLine("$Test to check a card object has been properly created\n\n" + "Int representing the suit {1}" + "   " + "The int representing value {2}" + "   " + "and finally its face values {3}" + "\n", "\n", testCard.suit, testCard.value, testCard.aface);

            Pack testPack = new Pack();
            testPack.deck();
            testPack.TestPack();
            List<Card> cards = new List<Card>();

            Console.WriteLine("Please select a shuffle type, the choices are as follows;\n please enter;\n 1 for the x shuffle\n 2 for the y shuffle\n 3 for no shuffle");
            try
            {
                string shuffle = Console.ReadLine();
                int shuffleType =  Convert.ToInt32(shuffle);
                ;
                if ( shuffleType != 1 ||  shuffleType != 2 ||  shuffleType != 3)
                    {
                    Console.WriteLine("You entered an invalid option, please enter either; 1, 2, or 3 thankyou");
                     shuffle = Console.ReadLine();

                }
            }
            catch { }
            /* foreach (Card i in d)
            {
                Console.WriteLine(d.f);
            }*/
        }

    } 
}