using DanceFloor.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace DanceFloor.Builder
{
    public interface IDanceBuilder
    {
        IDanceBuilder Create();

        IDanceBuilder Name(string name);

        IDanceBuilder TorsoMotion(string description);

        IDanceBuilder HeadMotion(string description);

        IDanceBuilder ArmMotion(string description);

        IDanceBuilder LegMotion(string description);

        IDanceBuilder AvailableGenre(IGenre genre);

        IDance Build();
    }
}
