namespace PatternPrototype
{
    internal class Shoes : IMyCloneable<Shoes>
    {
        public string BrandName { get; set; }
        public float Size { get; set; }
        public string Color { get; set; }
        public decimal Price { get; set; }

        public Shoes Copy()
        {
            throw new NotImplementedException();
        }
    }
}
