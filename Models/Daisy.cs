using System;

namespace flowerShop
{
    public class Daisy : IGetWell
    {
        public double Color { get; set; }
        public string Name { get; set; }
        public string Cost { get; set; }
        public string PetalCount { get; set; }
        public double StemLength { get; set; }

        public override string ToString()
        {
            return $"A fanciful {Color} daisy with {PetalCount} petals.";
        }
    }
}
