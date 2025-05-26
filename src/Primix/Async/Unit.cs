namespace Primix.Async
{
    internal readonly struct Unit
    {
        public static readonly Unit Value = new Unit();
        public override string ToString() => "()";
    }
}
