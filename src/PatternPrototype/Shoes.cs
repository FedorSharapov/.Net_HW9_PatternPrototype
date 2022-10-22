namespace PatternPrototype
{
    internal class Shoes : IMyCloneable<Shoes>
    {
        public string BrandName { get; init; }
        public float Size { get; init; }
        public string Color { get; init; }
        public decimal Price { get; init; }

        public Shoes(string brandName, float size, string color, decimal price)
        {
            BrandName = brandName;
            Size = size;
            Color = color;
            Price = price;
        }

        public Shoes Copy()
        {
            return new Shoes(BrandName, Size, Color, Price);
        }
    }
}
