using System;

namespace flowerShop
{
    public class Rose : IMothersday
    {
        public string Name { get; set; }
        public string Cost { get; set; }
        public string PetalCount { get; set; }
        public double StemLength { get; set; }

        public override string ToString()
        {
            return $"A fanciful rose with {PetalCount} petals.";
        }
    }
}
