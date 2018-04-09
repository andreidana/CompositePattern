namespace CompositePattern
{
    public interface IComputerPart
    {
        int Price { get; set; }  

        void Buy();
        void Add(IComputerPart item);
        void Remove(IComputerPart item);
        IComputerPart GetChild(int index);
    }
}