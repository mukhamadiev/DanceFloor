using System;
using System.Collections.Generic;
using System.Text;

namespace DanceFloor.Domain
{
    public interface ITrack
    {
        int Number { get; set; }

        IGenre Genre { get; set; }
    }
}
