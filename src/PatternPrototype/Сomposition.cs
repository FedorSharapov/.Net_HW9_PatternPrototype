namespace PatternPrototype
{
    /// <summary>
    /// Состав обуви
    /// </summary>
    public class Сomposition : IMyCloneable<Сomposition>, ICloneable
    {
        /// <summary>
        /// Материал верхней части обуви
        /// </summary>
        public string TopMaterial { get; init; }
        /// <summary>
        /// Материал подошвы
        /// </summary>
        public string OutsoleMaterial { get; init; }

        public Сomposition(string topMaterial, string outsoleMaterial)
        {
            TopMaterial = topMaterial;
            OutsoleMaterial = outsoleMaterial;
        }

        public Сomposition FullCopy()
        {
            return new Сomposition(TopMaterial, OutsoleMaterial);
        }

        public object Clone()
        {
            return FullCopy();
        }
    }
}
