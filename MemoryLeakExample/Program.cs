using System;

namespace MemoryLeakExample
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                BigItem bigItem = new BigItem();
                Event += bigItem.OnEvent;

                // do
                // many
                // things
                // here

                Event -= bigItem.OnEvent;
            }
        }

        public static event EventHandler Event;
    }
}
