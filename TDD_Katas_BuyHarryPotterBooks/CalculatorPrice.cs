using System.Collections.Generic;
using System.Linq;

namespace TDD_Katas_BuyHarryPotterBooks
{
    public class CalculatorPrice
    {
        private const double ONEBOOKPRICE = 100;
        private readonly Dictionary<int, double> DISCOUNTS = new Dictionary<int, double>()
        {
            {1, 0 },
            {2, 0.05 },
            {3, 0.1 },
            {4, 0.2 },
            {5, 0.25 },
        };

        private IList<int> _books = null;

        public CalculatorPrice(IList<int> books)
        {
            this._books = books;
        }

        public double BuyBooksPrice()
        {
            return DiscountsPrice() + NotDiscountsPrice();
        }

        private double DiscountsPrice()
        {
            var differentBooksCount = _books.Count(s => s >= 1);
            double discountsPrice = 0;

            if (differentBooksCount != 0)
            {
                discountsPrice = differentBooksCount * ONEBOOKPRICE
                        * (1 - DISCOUNTS[differentBooksCount > 5 ? 5 : differentBooksCount]);
            }
            return discountsPrice;
        }

        private double NotDiscountsPrice()
        {
            return (ONEBOOKPRICE * _books
                        .Where(booksNumber => booksNumber > 1)
                        .Sum(booksNumber => (booksNumber - 1)));
        }
    }
}
