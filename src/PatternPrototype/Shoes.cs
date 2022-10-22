namespace PatternPrototype
{
    /// <summary>
    /// Обувь
    /// </summary>
    public class Shoes : IMyCloneable<Shoes>
    {
        private uint _price;

        /// <summary>
        /// Имя бренда
        /// </summary>
        public string BrandName { get; init; }

        /// <summary>
        /// Наименование модели
        /// </summary>
        public string ModelName { get; init; }

        /// <summary>
        /// Размер обуви
        /// </summary>
        public float Size { get; init; }

        /// <summary>
        /// Состав обуви
        /// </summary>
        public Сomposition Composition { get; init; }

        /// <summary>
        /// Цвет обуви
        /// </summary>
        public string Color { get; init; }

        /// <summary>
        /// Цена обуви
        /// </summary>
        public uint Price => _price;

        /// <summary>
        /// Установить цену
        /// </summary>
        /// <param name="price">цена</param>
        /// <returns>this Shoes</returns>
        public Shoes SetPrice(uint price)
        {
            _price = price;
            return this;
        }

        public Shoes(string brandName, string modelName, float size, Сomposition composition, string color)
        {
            BrandName = brandName;
            ModelName = modelName;
            Size = size;
            Composition = composition;
            Color = color;
        }

        public Shoes Copy()
        {
            var replica = new Shoes(BrandName, ModelName, Size, Composition, Color)
                .SetPrice(_price);

            return replica;
        }
    }
}
