using System;
using System.Collections.Generic;
using System.Text;

namespace DanceFloor.Domain
{
    public interface IDance
    {
        string Name { get; set; }

        IList<IGenre> AvailableGenres { get; set; }

        IList<IMotion> Motions { get; set; }
    }
}