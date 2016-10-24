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
        const double DISCOUNTS_10 = 0.1;
        const double DISCOUNTS_20 = 0.2;
        const double DISCOUNTS_25 = 0.25;

        public double BuyBooksPrice(List<int> BooksNumbers)
        {
            double price = 0;
            
            CalculatorTotalPrice(BooksNumbers, ref price);

            return price;
        }

        private static void CalculatorTotalPrice(List<int> BooksNumbers, ref double price)
        {
            int DifferentEpisode = 0;

            for (int i = 0; i < BooksNumbers.Count; i++)
            {
                if (BooksNumbers[i] > 0)
                {
                    price += OneBookPrice;
                    DifferentEpisode++;
                }
            }

            price = CalculatorDiscounts(price, DifferentEpisode);

            for (int i = 0; i < BooksNumbers.Count; i++)
            {
                if (BooksNumbers[i] > 1)
                {
                    price += ( BooksNumbers[i] - 1 ) * OneBookPrice;
                    DifferentEpisode++;
                }
            }
        }

        private static double CalculatorDiscounts(double price, int DifferentEpisode)
        {
            switch (DifferentEpisode)
            {
                case 2:
                    price = price * (1 - DISCOUNTS_5);
                    break;
                case 3:
                    price = price * (1 - DISCOUNTS_10);
                    break;
                case 4:
                    price = price * (1 - DISCOUNTS_20);
                    break;
                case 5:
                    price = price * (1 - DISCOUNTS_25);
                    break;
                default:
                    if (DifferentEpisode >= 6)
                    {
                        price = price * (1 - DISCOUNTS_25);
                    }
                    break;
            }
            return price;
        }
    }
}
