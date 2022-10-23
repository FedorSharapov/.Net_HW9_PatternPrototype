namespace PatternPrototype
{
    /// <summary>
    /// Кроссовки
    /// </summary>
    public class Sneakers : SportShoes, IMyCloneable<Sneakers>, ICloneable
    {
        private string _workoutType;

        /// <summary>
        /// Тип тренировки
        /// </summary>
        public string WorkoutType => _workoutType;

        /// <summary>
        /// Установить тип тренировки
        /// </summary>
        /// <param name="workoutType">Тип тренировки</param>
        /// <returns>this Sneakers</returns>
        public Sneakers SetWorkoutType(string workoutType)
        {
            _workoutType = workoutType;
            return this;
        }
        /// <summary>
        /// Установить вид спорта
        /// </summary>
        /// <param name="sportType">Вид спорта</param>
        /// <returns>this Sneakers</returns>
        public new Sneakers SetSportType(string sportType)
        {
            base.SetSportType(sportType);
            return this;
        }

        /// <summary>
        /// Установиь особенности обуви
        /// </summary>
        /// <param name="features">Особенности обуви</param>
        /// <returns>this Sneakers</returns>
        public new Sneakers SetFeatures(string features)
        {
            base.SetFeatures(features);
            return this;
        }

        /// <summary>
        /// Установить цену
        /// </summary>
        /// <param name="price">цена</param>
        /// <returns>this Sneakers</returns>
        public new Sneakers SetPrice(uint price)
        {
            base.SetPrice(price);
            return this;
        }

        public Sneakers(string brandName, string modelName, float size, Сomposition composition, string color)
            : base(brandName, modelName, size, composition, color)
        {
            _workoutType = "";
        }

        public override Sneakers FullCopy()
        {
            var replica = new Sneakers(BrandName, ModelName, Size, Composition, Color)
                .SetPrice(Price)
                .SetFeatures(Features)
                .SetSportType(SportType)
                .SetWorkoutType(_workoutType);

            return replica;
        }

        /*public new object Clone()
        {
            return Copy();
        }*/
    }
}
