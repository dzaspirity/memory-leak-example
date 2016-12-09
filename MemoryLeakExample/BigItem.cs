using System;

namespace MemoryLeakExample
{
    public class BigItem
    {
        public const int Size = 100;

        public string Body { get; } = string.Empty.PadRight(Size);
    }
}
