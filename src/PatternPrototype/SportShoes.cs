namespace PatternPrototype
{
    internal class SportShoes : Shoes, IMyCloneable<SportShoes>
    {
        public string SportType { get; set; }
        public string Features { get; set; }

        public SportShoes Copy()
        {
            throw new NotImplementedException();
        }
    }
}
