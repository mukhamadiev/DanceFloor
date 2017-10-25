namespace DanceFloor.Domain.Impl
{
    using System.Collections.Generic;

    /// <summary>
    ///     Танец
    /// </summary>
    public class Dance : IDance
    {
        /// <inheritdoc />
        public string Name { get; set; }

        /// <inheritdoc />
        public IList<IGenre> AvailableGenres { get; set; } = new List<IGenre>();

        /// <inheritdoc />
        public IList<IMotion> Motions { get; set; } = new List<IMotion>();

        /// <inheritdoc />
        public override string ToString()
        {
            return $"Танец: {this.Name}";
        }
    }
}