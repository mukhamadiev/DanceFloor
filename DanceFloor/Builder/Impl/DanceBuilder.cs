using System;
using System.Collections.Generic;
using System.Text;
using DanceFloor.Domain;
using DanceFloor.Domain.Impl;
using DanceFloor.Enum;

namespace DanceFloor.Builder.Impl
{
    public class DanceBuilder : IDanceBuilder
    {
        private Dance dance;

        public IDanceBuilder ArmMotion(string description)
        {
            this.dance.Motions.Add(new Motion
            {
                BodyPart = BodyPart.Arm,
                Description = description
            });

            return this;
        }

        public IDanceBuilder AvailableGenre(IGenre genre)
        {
            this.dance.AvailableGenres.Add(genre);

            return this;
        }

        public IDance Build()
        {
            return this.dance;
        }

        public IDanceBuilder Create()
        {
            this.dance = new Dance();

            return this;
        }

        public IDanceBuilder HeadMotion(string description)
        {
            this.dance.Motions.Add(new Motion
            {
                BodyPart = BodyPart.Head,
                Description = description
            });

            return this;
        }

        public IDanceBuilder LegMotion(string description)
        {
            this.dance.Motions.Add(new Motion
            {
                BodyPart = BodyPart.Leg,
                Description = description
            });

            return this;
        }

        public IDanceBuilder Name(string name)
        {
            this.dance.Name = name;

            return this;
        }

        public IDanceBuilder TorsoMotion(string description)
        {
            this.dance.Motions.Add(new Motion
            {
                BodyPart = BodyPart.Torso,
                Description = description
            });

            return this;
        }
    }
}
