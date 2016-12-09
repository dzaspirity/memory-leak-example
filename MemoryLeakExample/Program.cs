using System;
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
                bigItem.Event += BigItemOnEvent;  
            }
        }

        private static void BigItemOnEvent(object sender, EventArgs eventArgs)
        {
            // do nothing
        }
    }
}
