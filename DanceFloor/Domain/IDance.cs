namespace DanceFloor.Domain
{
    using System.Collections.Generic;

    /// <summary>
    ///     Танец
    /// </summary>
    public interface IDance
    {
        /// <summary>
        ///     Название
        /// </summary>
        string Name { get; set; }

        /// <summary>
        ///     Доступные жанры
        /// </summary>
        IList<IGenre> AvailableGenres { get; set; }

        /// <summary>
        ///     Движения
        /// </summary>
        IList<IMotion> Motions { get; set; }
    }
}