using System;
using System.Collections.Generic;
using System.Text;

namespace DanceFloor.Domain
{
    public interface IBehavior
    {
        string Name { get; set; }

        void Apply(IClub club, IDancer dancer);
    }
}
