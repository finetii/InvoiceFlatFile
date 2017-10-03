namespace ReadFlatFiles
{
    internal partial class Position
    {
        public class EAN
        {
            public decimal Value { get; set; }
            public const int startPosition = 14;
            public const int length = 13;
        }
    }
}