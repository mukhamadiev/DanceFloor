using DanceFloor.Enum;
using System.Collections.Generic;

namespace DanceFloor.Domain
{
    public interface IDancer
    {
        string Name { get; set; }

        Sex Sex { get; set; }

        IList<IDance> AvailableDances { get; set; }

        State State { get; set; }
    }
}