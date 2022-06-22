using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    class Program
    {
		static void Main(string[] arcs)
		{

			Deck deck = new Deck();
			foreach (Card card in deck.Cards)
			{
				Console.WriteLine(card.Face + " of " + card.Suit);
			}
			Console.ReadLine();
		}

		public static Deck Shuffle(Deck deck, int times = 1)
        {
			for (int i = 0; i < times; i++)
            {
				List<Card> TempList = new List<Card>();
				Random random = new Random();

				while (deck.Cards.Count > 0)
				{
					int randomIndex = random.Next(0, deck.Cards.Count);
					TempList.Add(deck.Cards[randomIndex]);
					deck.Cards.RemoveAt(randomIndex);
				}
				deck.Cards = TempList;
			}
			return deck;
		}
	}
}
        
    

