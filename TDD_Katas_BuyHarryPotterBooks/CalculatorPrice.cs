using System.Collections.Generic;
using System.Linq;

namespace TDD_Katas_BuyHarryPotterBooks
{
    public class CalculatorPrice
    {
        private const double OneBookPrice = 100;
        private static Dictionary<int, double> DISCOUNTS = new Dictionary<int, double>()
        {
            {1, 0 },
            {2, 0.05 },
            {3, 0.1 },
            {4, 0.2 },
            {5, 0.25 },
        };

        public double BuyBooksPrice(IList<int> booksNumbers)
        {
            return CalcDiscountsPrice(booksNumbers) +
                    NotDiscounts(booksNumbers);
        }

        private static double CalcDiscountsPrice(IList<int> booksNumbers)
        {
            int diffBooksCount = booksNumbers.Count(s => s >= 1);
            double price = 0;

            if (diffBooksCount != 0)
            {
                price = diffBooksCount * OneBookPrice
                        * (1 - DISCOUNTS[diffBooksCount > 5 ? 5 : diffBooksCount]);
            }
            return price;
        }

        private static double NotDiscounts(IList<int> booksNumbers)
        {
            return (OneBookPrice *
                    booksNumbers
                        .Where(booksNumber => booksNumber > 1)
                        .Sum(booksNumber => (booksNumber - 1)));
        }
    }
}
