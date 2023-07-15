namespace BlazorCodemy.Shared
{
    public class ShopElement
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public string ImageUrl { get; set; }    

        public double Price { get; set; }

        public List<Shipping> shippings { get; set; }=new List<Shipping>();
    }
}