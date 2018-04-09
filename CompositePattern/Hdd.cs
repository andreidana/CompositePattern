namespace CompositePattern
{
    public class Hdd: IComputerPart
    {
        public int Price { get; set; }
        public void Buy()
        {
            Price += 100;
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