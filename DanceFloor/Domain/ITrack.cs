﻿namespace DanceFloor.Domain
{
    /// <summary>
    ///     Трек
    /// </summary>
    public interface ITrack
    {
        /// <summary>
        ///     Номер
        /// </summary>
        int Number { get; set; }

        /// <summary>
        ///     Жанр
        /// </summary>
        IGenre Genre { get; set; }
    }
}