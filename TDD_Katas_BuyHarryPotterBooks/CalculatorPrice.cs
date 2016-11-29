using System.Collections.Generic;
using System.Linq;

namespace TDD_Katas_BuyHarryPotterBooks
{
    public class CalculatorPrice
    {
        private const double OneBookPrice = 100;
        private static Dictionary<int, double> DISCOUNTS = new Dictionary<int, double>()
        {
            {2, 0.05 },
            {3, 0.1 },
            {4, 0.2 },
            {5, 0.25 },
        };

        public double BuyBooksPrice(IList<int> booksNumbers)
        {
            return CalculatorTotalPrice(booksNumbers);
        }

        private static double CalculatorTotalPrice(IList<int> booksNumbers)
        {
            return Discounts(booksNumbers) +
                NoDiscounts(booksNumbers);
        }

        private static double Discounts(IEnumerable<int> booksNumbers)
        {
            int differentEpisode = 0;
            double price = 0;

            foreach (int booksNumber in booksNumbers)
            {
                if (booksNumber <= 0) continue;

                price += OneBookPrice;
                differentEpisode++;
            }

            return DiscountsPrice(differentEpisode, price);
        }

        private static double DiscountsPrice(int differentEpisode, double price)
        {
            if (DISCOUNTS.ContainsKey(differentEpisode))
            {
                price = price * (1 - DISCOUNTS[differentEpisode]);
            }
            //買5本以上不同集數的書，一律以5集折扣計算
            if (differentEpisode >= 6)
            {
                price = price * (1 - DISCOUNTS[5]);
            }
            return price;
        }

        private static double NoDiscounts(IEnumerable<int> booksNumbers)
        {
            return booksNumbers
                .Where(booksNumber => booksNumber > 1)
                .Sum(booksNumber =>
                        (booksNumber - 1) * OneBookPrice);
        }
    }
}
