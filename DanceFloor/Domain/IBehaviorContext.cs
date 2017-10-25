namespace DanceFloor.Domain
{
    /// <summary>
    ///     Контекст поведения
    /// </summary>
    public interface IBehaviorContext
    {
        /// <summary>
        ///     Жанр
        /// </summary>
        IGenre Genre { get; set; }
    }
}