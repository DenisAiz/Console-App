using System.Collections.Generic;
using Task3.Space;

namespace Task3
{
    class Informator
    {
        public void InformsAboutObjects()
        {
            var writer = new Writer();

            var asteroid = new Asteroid
            {
                Name = "Икар",

                Description = "Небольшой околоземный астероид из группы аполлонов, " +
                "который характеризуется крайне вытянутой орбитой. Он был открыт" +
                "немецким астрономом Вальтером Бааде в Паломарской обсерватории США и назван в честь Икара," +
                "персонажа древнегреческой мифологии, известного своей необычной смертью",

                Weight = "990000000"
            };

            BlackHole blackHole = new BlackHole
            {
                Name = "Holmberg 15A",

                Description = "Сверхгигантская эллиптическая галактика типа cD в скоплении галактик " +
                "Abell 85 в созвездии Кита на расстоянии около 700 млн световых лет от Солнца",

                Diameter = "1500000"
            };

            Planet planet = new Planet
            {
                Name = "Марс",

                Description = "Четвёртая по удалённости от Солнца и седьмая по размеру планета" +
                "Солнечной системы; масса планеты составляет 10,7 % массы Земли." +
                "Названа в честь Марса — древнеримского бога войны, соответствующего древнегреческому Аресу.",

                DistanceFromEarth = "55760000"
            };

            Star star = new Star
            {
                Name = "Сириус",

                Description = "Звезда созвездия Большого Пса. Звезда главной последовательности" +
                "спектрального класса A1. Ярчайшая звезда ночного неба," +
                "её светимость в 25 раз превышает светимость Солнца, при этом не является " +
                "рекордной в мире звёзд.",

                NumberOfYears = "230000000"
            };

            var spaceObjects = new List<SpaceObject>();

            spaceObjects.Add(star);
            spaceObjects.Add(planet);
            spaceObjects.Add(asteroid);
            spaceObjects.Add(blackHole);

            writer.AddContent(spaceObjects);
        }
    }
}
