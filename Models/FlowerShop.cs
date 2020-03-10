using System;
using System.Collections.Generic;

namespace flowerShop
{
    public class flowerShop
    {
        public List<Rose> Roses = new List<Rose>();
        public List<Lily> Lily = new List<Lily>();
        public List<SunFlower> SunFlower = new List<SunFlower>();
        public List<Tulip> Tulip = new List<Tulip>();
        public List<Daisy> Daisy = new List<Daisy>();

        public List<IMothersday> MakeMothersdayArrangment()
        {
            List<IMothersday> Arrangment = new List<IMothersday>();
            Arrangment.Add(new Rose());
            Arrangment.Add(new Rose());
            Arrangment.Add(new Tulip());
            Arrangment.Add(new Tulip());
            Arrangment.Add(new Tulip());

            return Arrangment;
        }

        public List<IBirthday> MakeBirthdayArrangment()
        {
            List<IBirthday> Arrangment = new List<IBirthday>();
            Arrangment.Add(new SunFlower());
            Arrangment.Add(new SunFlower());
            Arrangment.Add(new Lily());
            Arrangment.Add(new Lily());
            Arrangment.Add(new Lily());

            return Arrangment;
        }

        public List<IGetWell> MakeGetWellArrangment()
        {
            List<IGetWell> Arrangment = new List<IGetWell>();
            Arrangment.Add(new Daisy());
            Arrangment.Add(new Daisy());
            Arrangment.Add(new Daisy());

            return Arrangment;
        }
    }
}
