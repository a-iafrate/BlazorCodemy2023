using System.Drawing;

namespace BlazorCodemy.Shared
{
    public class ShopElement
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public string ImageUrl { get; set; }    

        public double Price { get; set; }

        public List<Shipping> Shippings { get; set; }=new List<Shipping>();

        public double GetTotalPrice()
        {
            return GetBasePrice() + Shippings.Sum(t => t.Price);
        }

        public string GetFormattedTotalPrice()
        {
            return GetTotalPrice().ToString("0.00");
        }

        public double GetBasePrice()
        {
            return Price;
        }
    }
}