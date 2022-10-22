namespace PatternPrototype
{
    internal class Sneakers : SportShoes, IMyCloneable<Sneakers>
    {
        public string WorkoutType { get; init; }
        public string ModelName { get; init; }
        public Сomposition Сomposition { get; init; }

        public Sneakers(string workoutType, string modelName, Сomposition composition, string sportType, string features, string brandName, float size, string color, decimal price) : base( sportType, features, brandName, size, color, price)
        {
            WorkoutType = workoutType;
            ModelName = modelName;
            Сomposition = composition;
        }

        public Sneakers Copy()
        {
            return new Sneakers(WorkoutType, ModelName, Сomposition.Copy(), SportType, Features, BrandName, Size, Color, Price);
        }
    }
}
