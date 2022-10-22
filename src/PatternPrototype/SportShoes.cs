namespace PatternPrototype
{
    internal class SportShoes : Shoes, IMyCloneable<SportShoes>
    {
        public string SportType { get; init; }
        public string Features { get; init; }

        public SportShoes(string sportType, string features, string brandName, float size, string color, decimal price) : base(brandName, size, color, price)
        {
            SportType = sportType;
            Features = features;
        }

        public SportShoes Copy()
        {
            return new SportShoes(SportType, Features, BrandName, Size, Color, Price);
        }
    }
}
