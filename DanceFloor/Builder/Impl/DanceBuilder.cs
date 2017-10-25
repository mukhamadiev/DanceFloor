namespace DanceFloor.Builder.Impl
{
    using Domain;
    using Domain.Impl;
    using Enum;

    /// <summary>
    ///     Строитель для <see cref="Dance" />
    /// </summary>
    public class DanceBuilder : IDanceBuilder
    {
        private Dance dance;

        /// <inheritdoc />
        public IDanceBuilder ArmMotion(string description)
        {
            this.dance.Motions.Add(new Motion
            {
                BodyPart = BodyPart.Arm,
                Description = description
            });

            return this;
        }

        /// <inheritdoc />
        public IDanceBuilder AvailableGenre(IGenre genre)
        {
            this.dance.AvailableGenres.Add(genre);

            return this;
        }

        /// <inheritdoc />
        public IDance Build()
        {
            return this.dance;
        }

        /// <inheritdoc />
        public IDanceBuilder Create()
        {
            this.dance = new Dance();

            return this;
        }

        /// <inheritdoc />
        public IDanceBuilder HeadMotion(string description)
        {
            this.dance.Motions.Add(new Motion
            {
                BodyPart = BodyPart.Head,
                Description = description
            });

            return this;
        }

        /// <inheritdoc />
        public IDanceBuilder LegMotion(string description)
        {
            this.dance.Motions.Add(new Motion
            {
                BodyPart = BodyPart.Leg,
                Description = description
            });

            return this;
        }

        /// <inheritdoc />
        public IDanceBuilder Name(string name)
        {
            this.dance.Name = name;

            return this;
        }

        /// <inheritdoc />
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