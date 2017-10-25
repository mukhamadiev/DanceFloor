namespace DanceFloor.Domain.Impl
{
    /// <summary>
    ///     Контекст поведения
    /// </summary>
    public class BehaviorContext : IBehaviorContext
    {
        /// <summary>
        ///     .ctor
        /// </summary>
        /// <param name="genre">Жанр</param>
        public BehaviorContext(IGenre genre)
        {
            this.Genre = genre;
        }

        /// <inheritdoc />
        public IGenre Genre { get; set; }
    }
}