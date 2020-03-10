using System;

namespace flowerShop
{
    public class SunFlower : IBirthday
    {
        public double Color { get; set; }
        public string Name { get; set; }
        public string Cost { get; set; }
        public string PetalCount { get; set; }

        public override string ToString()
        {
            return $"A fanciful {Color} sunflower with {PetalCount} petals.";
        }
    }
}
