namespace DanceFloor.Util
{
    using System.Collections.Generic;
    using System.Linq;
    using Builder.Impl;
    using Domain;
    using Domain.Impl;
    using Enum;

    /// <summary>
    ///     Эмулятор
    /// </summary>
    public class Emulator
    {
        private static Emulator emulator;

        private Emulator()
        {
        }

        /// <summary>
        ///     Клуб
        /// </summary>
        public IClub Club { get; private set; }

        /// <summary>
        ///     Репортер
        /// </summary>
        public IReporter Reporter { get; private set; }

        /// <summary>
        ///     Получить экземпляр
        /// </summary>
        public static Emulator GetInstance()
        {
            return emulator ?? (emulator = new Emulator());
        }

        /// <summary>
        ///     Инициализировать
        /// </summary>
        public void Init()
        {
            var genres = this.InitGenres();
            var dances = this.InitDances(genres);

            this.InitClub(genres, dances);
            this.InitReporter();
        }

        /// <summary>
        ///     Запустить
        /// </summary>
        public void Start()
        {
            this.Club.Dj.NextTrack();
        }

        private List<IGenre> InitGenres()
        {
            return new List<IGenre>
            {
                new Genre {Name = "Rnb"},
                new Genre {Name = "Electrohouse"},
                new Genre {Name = "Pop"}
            };
        }

        private List<ITrack> InitTracks(List<IGenre> genres)
        {
            var tracks = new List<ITrack>();

            var count = 10;
            for (var index = 0; index < count; index++)
                tracks.Add(new Track
                {
                    Number = index,
                    Genre = RandomHelper.GetRandomElement(genres)
                });

            return tracks;
        }

        private List<IDance> InitDances(List<IGenre> genres)
        {
            var genreMapper = genres.ToDictionary(g => g.Name, g => g);

            var danceBuilder = new DanceBuilder();

            var hipHopDance = danceBuilder.Create()
                .Name("Hip-hop")
                .ArmMotion("согнуты в локтях")
                .TorsoMotion("покачивания перед-назад")
                .HeadMotion("покачивания перед-назад")
                .LegMotion("в полу-присяде")
                .AvailableGenre(genreMapper["Rnb"])
                .Build();

            var rnbDance = danceBuilder.Create()
                .Name("Rnb")
                .ArmMotion("согнуты в локтях")
                .TorsoMotion("покачивания перед-назад")
                .HeadMotion("покачивания перед-назад")
                .LegMotion("в полу-присяде")
                .AvailableGenre(genreMapper["Rnb"])
                .Build();

            var electroDance = danceBuilder.Create()
                .Name("Electrodance")
                .ArmMotion("круговые движения-вращения")
                .TorsoMotion("покачивания перед-назад")
                .HeadMotion("почти нет движения")
                .LegMotion("двигаются в ритме")
                .AvailableGenre(genreMapper["Electrohouse"])
                .Build();

            var houseDance = danceBuilder.Create()
                .Name("House")
                .ArmMotion("круговые движения-вращения")
                .TorsoMotion("покачивания перед-назад")
                .HeadMotion("почти нет движения")
                .LegMotion("двигаются в ритме")
                .AvailableGenre(genreMapper["Electrohouse"])
                .Build();

            var popDance = danceBuilder.Create()
                .Name("Pop")
                .ArmMotion("плавные движения")
                .TorsoMotion("плавные движения")
                .HeadMotion("плавные движения")
                .LegMotion("плавные движения")
                .AvailableGenre(genreMapper["Pop"])
                .Build();

            return new List<IDance>
            {
                hipHopDance,
                rnbDance,
                electroDance,
                houseDance,
                popDance
            };
        }

        private List<IDancer> InitDancers(List<IDance> dances)
        {
            var dancers = new List<IDancer>
            {
                new Dancer
                {
                    Name = "Иван",
                    Sex = Sex.Male,
                    AvailableDances = dances.Where(d => d.Name == "Hip-hop").ToList()
                },
                new Dancer
                {
                    Name = "Артём",
                    Sex = Sex.Male,
                    AvailableDances = dances.Where(d => d.Name == "Electrodance").ToList()
                },
                new Dancer
                {
                    Name = "Алёна",
                    Sex = Sex.Female,
                    AvailableDances = dances.Where(d => d.Name == "Pop").ToList()
                }
            };

            return dancers;
        }

        private void InitClub(List<IGenre> genres, List<IDance> dances)
        {
            var behavior = new Behavior();
            var dj = new Dj
            {
                Name = "ZHU",
                Tracks = this.InitTracks(genres)
            };

            this.Club = new Club
            {
                Name = "FIX",
                Dj = dj,
                Behavior = behavior,
                Dancers = this.InitDancers(dances)
            };

            dj.ChangedHandler += this.Club.ApplyBehavior;
        }

        private void InitReporter()
        {
            this.Reporter = new Reporter();

            this.Reporter.Init(this.Club);
        }
    }
}