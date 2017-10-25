using DanceFloor.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace DanceFloor.Domain
{
    public interface IMotion
    {
        BodyPart BodyPart { get; set; }

        string Description { get; set; }
    }
}
