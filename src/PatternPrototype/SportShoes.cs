namespace PatternPrototype
{
    /// <summary>
    /// Спортивная обувь
    /// </summary>
    public class SportShoes : Shoes, IMyCloneable<SportShoes>, ICloneable
    {
        private string _sportType;
        private string _features;

        /// <summary>
        /// Вид спорта
        /// </summary>
        public string SportType => _sportType;

        /// <summary>
        /// Особенности обуви
        /// </summary>
        public string Features => _features;

        /// <summary>
        /// Установить вид спорта
        /// </summary>
        /// <param name="sportType">Вид спорта</param>
        /// <returns>this SportShoes</returns>
        public SportShoes SetSportType(string sportType)
        {
            _sportType = sportType;
            return this;
        }

        /// <summary>
        /// Установиь особенности обуви
        /// </summary>
        /// <param name="features">Особенности обуви</param>
        /// <returns>this SportShoes</returns>
        public SportShoes SetFeatures(string features)
        {
            _features = features;
            return this;
        }

        /// <summary>
        /// Установить цену
        /// </summary>
        /// <param name="price">цена</param>
        /// <returns>this SportShoes</returns>
        public new SportShoes SetPrice(uint price)
        {
            base.SetPrice(price);
            return this;
        }

        public SportShoes(string brandName, string modelName, float size, Сomposition composition, string color) 
            : base(brandName, modelName, size, composition, color) 
        {
            _sportType = "";
            _features = "";
        }

        public new SportShoes Copy()
        {
            var replica = new SportShoes(BrandName, ModelName, Size, Composition, Color)
                .SetPrice(Price)
                .SetFeatures(_features)
                .SetSportType(_sportType);

            return replica;
        }

        public new object Clone()
        {
            return Copy();
        }
    }
}
