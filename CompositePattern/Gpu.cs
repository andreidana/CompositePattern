namespace CompositePattern
{
    public class Gpu: IComputerPart
    {
        public int Price { get; set; }
        public void Buy()
        {
            Price += 400;
        }

        public void Add(IComputerPart item)
        {
            throw new System.NotImplementedException();
        }

        public void Remove(IComputerPart item)
        {
            throw new System.NotImplementedException();
        }

        public IComputerPart GetChild(int index)
        {
            throw new System.NotImplementedException();
        }
    }
}