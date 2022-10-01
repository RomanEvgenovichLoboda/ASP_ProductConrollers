namespace WebApplicationASP.Model
{
    public class ProductModel
    {
        public ProductModel() { }
        public ProductModel(int _id, string _name,string _cat, double _price)
        {
            Id = _id;
            Name = _name;
            Category = _cat;
            Price = _price;
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public double Price { get; set; }

    }
}
