using System.Collections.Generic;

namespace CompositePattern
{
    public class Computer: IComputerPart
    {
        public int Price { get; set; }
        public List<IComputerPart> Pieces { get; set; }

        public Computer()
        {
            Pieces = new List<IComputerPart>();
        }

        public void Buy()
        {
            foreach (var computerPart in Pieces)
            {
                computerPart.Buy();
                Price += computerPart.Price;
            }
        }

        public void Add(IComputerPart item)
        {
            Pieces.Add(item);
        }

        public void Remove(IComputerPart item)
        {
            Pieces.Remove(item);
        }

        public IComputerPart GetChild(int index)
        {
            return Pieces[index];
        }
    }
}