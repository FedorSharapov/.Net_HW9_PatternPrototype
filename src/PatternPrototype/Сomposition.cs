namespace PatternPrototype
{
    internal class Сomposition : IMyCloneable<Сomposition>
    {
        public string TopMaterial { get; set; }
        public string OutsoleMaterial { get; set; }

        public Сomposition Copy()
        {
            throw new NotImplementedException();
        }
    }
}
