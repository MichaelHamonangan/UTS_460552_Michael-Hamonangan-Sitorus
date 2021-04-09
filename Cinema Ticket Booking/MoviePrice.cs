using System;
using System.Collections.Generic;
using System.Text;

namespace UTS_460552
{
    class MoviePrice
    {
        protected int price;
        public int Price { get => price; set => price = value; }
        public int total;

        public MoviePrice(int price)
        {
            this.Price = price;
        }

        public void totalPrices(int n)
        {
            total = price * n;
        }
    }
}
