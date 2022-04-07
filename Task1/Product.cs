namespace Task1
{
    public class Product
    {
        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public string Name { get; set; }

        public double Price { get; set; }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;

            Product p = obj as Product;
            if (p == null)
                return false;

            return (Name == p.Name) && (Price == p.Price);
        }
        public override int GetHashCode()
        {
            return Name.GetHashCode() ^ Price.GetHashCode();
        }
    }
}
