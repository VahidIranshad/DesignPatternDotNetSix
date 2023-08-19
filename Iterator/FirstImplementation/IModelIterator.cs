namespace Iterator.FirstImplementation
{
    internal interface IModelIterator
    {
        Model First();
        Model Next();
        bool IsDone { get; }
        Model CurrentBean { get; }
    }
}
