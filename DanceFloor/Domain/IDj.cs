using System;
using System.Collections.Generic;
using System.Text;

namespace DanceFloor.Domain
{
    public interface IDj
    {
        string Name { get; set; }

        IList<ITrack> Tracks { get; set; }

        ITrack CurrentTrack { get; set; }

        void NextTrack();
    }
}
