using System;
using System.Collections.Generic;
using System.Text;

namespace DanceFloor.Domain.Impl
{
    public class Dance : IDance
    {
        public string Name { get; set; }

        public IList<IGenre> AvailableGenres { get; set; } = new List<IGenre>();

        public IList<IMotion> Motions { get; set; } = new List<IMotion>();
    }
}
