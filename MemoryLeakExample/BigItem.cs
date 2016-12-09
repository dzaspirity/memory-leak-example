using System;

namespace MemoryLeakExample
{
    public class BigItem
    {
        public const int Size = 150;

        public string Body { get; } = string.Empty.PadRight(Size);

        public event EventHandler Event;

        public void OnEvent(object sender, EventArgs eventArgs)
        {
            // do nothing
        }

    }
}
