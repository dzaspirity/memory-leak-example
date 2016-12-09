using System.Collections.Generic;

namespace MemoryLeakExample
{
    class Program
    {
        static void Main(string[] args)
        {
            List<BigItem> list = new List<BigItem>();
            while (true)
            {
                BigItem bigItem = new BigItem();
                list.Add(bigItem);
            }
        }
    }
}
