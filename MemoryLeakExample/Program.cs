using System.Collections.Generic;

namespace MemoryLeakExample
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                BigItem bigItem = new BigItem();
            }
        }
    }
}
