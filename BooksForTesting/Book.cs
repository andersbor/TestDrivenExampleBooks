#define CONTRACTS_FULL
using System;
using System.Diagnostics.Contracts;

namespace BooksForTesting
{
    public class Book
    {
       

        private double _price;
        public string Title { get; set; }
        public string Author { get; set; }

        public double Price
        {
            get => _price;
            set
            {
                if (value < 0.0) throw new ArgumentOutOfRangeException();
                _price = value;
            }
        }

        public override string ToString()
        {
            return Author + " " + Title + " " + Price;
        }
    }
}
