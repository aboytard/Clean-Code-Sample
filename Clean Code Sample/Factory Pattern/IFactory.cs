namespace Clean_Code_Sample.Factory_Pattern
{
    public interface IFactory
    {
        IFactory Create(object someObject);
    }
}
