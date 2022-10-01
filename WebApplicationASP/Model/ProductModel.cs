namespace WebApplicationASP.Model
{
    public class ProductModel
    {
        public ProductModel() { }
        public ProductModel( string _name,string _cat, double _price)
        {
            Count++;
            Id = Count;
            Name = _name;
            Category = _cat;
            Price = _price;
        }
        static int Count { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public double Price { get; set; }

    }
}
