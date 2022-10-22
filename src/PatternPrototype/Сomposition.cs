namespace PatternPrototype
{
    internal class Сomposition : IMyCloneable<Сomposition>
    {
        public string TopMaterial { get; init; }
        public string OutsoleMaterial { get; init; }

        public Сomposition(string topMaterial, string outsoleMaterial)
        {
            TopMaterial = topMaterial;
            OutsoleMaterial = outsoleMaterial;
        }

        public Сomposition Copy()
        {
            return new Сomposition(TopMaterial, OutsoleMaterial);
        }
    }
}
