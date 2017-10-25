namespace DanceFloor.Domain.Impl
{
    /// <summary>
    ///     Трек
    /// </summary>
    public class Track : ITrack
    {
        /// <inheritdoc />
        public int Number { get; set; }

        /// <inheritdoc />
        public IGenre Genre { get; set; }

        /// <inheritdoc />
        public override string ToString()
        {
            return $"Трек: {this.Number} {this.Genre.Name}";
        }
    }
}