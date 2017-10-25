using DanceFloor.Builder.Impl;
using DanceFloor.Domain.Impl;
using System;
using System.Diagnostics;

namespace DanceFloor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var genre = new Genre
            {
                Name = "Rnb"
            };

            var danceBuilder = new DanceBuilder();

            var dance = danceBuilder.Create()
                .Name("Rnb")
                .ArmMotion("Круг")
                .TorsoMotion("Нет")
                .HeadMotion("Плавно")
                .LegMotion("Прыжки")
                .AvailableGenre(genre)
                .Build();

            Debugger.Break();
        }
    }
}
