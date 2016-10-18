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

        public double BuyBooksPrice(List<int> BooksNumbers)
        {
            double price = 0;
            for (int i = 0; i < BooksNumbers.Count; i++)
            {
                if (BooksNumbers[i] > 0)
                {
                    price += BooksNumbers[i] * OneBookPrice;
                }
            }
            return price;
        }
    }
}
