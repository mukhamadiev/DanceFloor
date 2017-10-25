using System;
using System.Collections.Generic;
using System.Text;

namespace DanceFloor.Domain
{
    public interface IClub
    {
        string Name { get; set; }

        IDj Dj { get; set; }

        IBehavior Behavior { get; set; }
    }
}
