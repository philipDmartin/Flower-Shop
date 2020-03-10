using System;

namespace flowerShop
{
    public class Tulip : IMothersday
    {
        public string Name { get; set; }
        public string Cost { get; set; }
        public string PetalCount { get; set; }
        public double StemLength { get; set; }


        public override string ToString()
        {
            return $"A fanciful tulip with {PetalCount} petals.";
        }
    }
}
