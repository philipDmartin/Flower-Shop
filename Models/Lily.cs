using System;

namespace flowerShop
{
    public class Lily : IBirthday
    {
        public double Color { get; set; }
        public string Name { get; set; }
        public string Cost { get; set; }
        public string PetalCount { get; set; }

        public override string ToString()
        {
            return $"A fanciful {Color} lily with {PetalCount} petals.";
        }
    }
}
