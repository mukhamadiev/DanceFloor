namespace DanceFloor.Domain
{
    using System;
    using System.Collections.Generic;
    using EventArg;

    /// <summary>
    ///     Диджей
    /// </summary>
    public interface IDj
    {
        /// <summary>
        ///     Обработчик изменения трека
        /// </summary>
        EventHandler<ChangeTrackEventArgs> ChangedHandler { get; set; }

        /// <summary>
        ///     Имя
        /// </summary>
        string Name { get; set; }

        /// <summary>
        ///     Треки
        /// </summary>
        IList<ITrack> Tracks { get; set; }

        /// <summary>
        ///     Текущий трек
        /// </summary>
        ITrack CurrentTrack { get; set; }

        /// <summary>
        ///     Переключить трек
        /// </summary>
        void NextTrack();
    }
}