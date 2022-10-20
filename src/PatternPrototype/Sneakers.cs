namespace PatternPrototype
{
    internal class Sneakers : SportShoes, IMyCloneable<Sneakers>
    {
        public string WorkoutType { get; set; }
        public string ModelName { get; set; }
        public Сomposition Сomposition { get; set; }

        public Sneakers Copy()
        {
            throw new NotImplementedException();
        }
    }
}
