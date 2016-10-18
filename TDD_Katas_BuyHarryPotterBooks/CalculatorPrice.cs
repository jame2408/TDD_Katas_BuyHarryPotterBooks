using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD_Katas_BuyHarryPotterBooks
{
    public class CalculatorPrice
    {
        const double OneBookPrice = 100;
        const double DISCOUNTS_5 = 0.05;

        public double BuyBooksPrice(List<int> BooksNumbers)
        {
            double price = 0;
            int DifferentEpisode = 0;

            CalculatorTotalPrice(BooksNumbers, ref price, ref DifferentEpisode);

            return price;
        }

        private static void CalculatorTotalPrice(List<int> BooksNumbers, ref double price, ref int DifferentEpisode)
        {
            for (int i = 0; i < BooksNumbers.Count; i++)
            {
                if (BooksNumbers[i] > 0)
                {
                    price += BooksNumbers[i] * OneBookPrice;
                    DifferentEpisode++;
                }
            }
            if (DifferentEpisode == 2)
            {
                price = price * (1 - DISCOUNTS_5);
            }
        }
    }
}
