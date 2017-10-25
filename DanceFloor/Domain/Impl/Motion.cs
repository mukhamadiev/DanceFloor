using System;
using System.Collections.Generic;
using System.Text;
using DanceFloor.Enum;

namespace DanceFloor.Domain.Impl
{
    public class Motion : IMotion
    {
        public BodyPart BodyPart { get; set; }
        public string Description { get; set; }
    }
}
