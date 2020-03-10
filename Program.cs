using System;
using System.Collections.Generic;

namespace flowerShop
{
    class Program
    {
        static void Main(string[] args)
        {
            Rose myRose = new Rose();
            Tulip myTulip = new Tulip();
            Lily myLilly = new Lily();
            SunFlower mySunFlower = new SunFlower();
            Daisy myDaisy = new Daisy();

            flowerShop MyFlowerShop = new flowerShop();
            List<IBirthday> Arrangment = MyFlowerShop.MakeBirthdayArrangment();
        }
    }
}
