namespace DanceFloor.Domain
{
    using System.Collections.Generic;
    using EventArg;

    /// <summary>
    ///     Клуб
    /// </summary>
    public interface IClub
    {
        /// <summary>
        ///     Название
        /// </summary>
        string Name { get; set; }

        /// <summary>
        ///     Диджей
        /// </summary>
        IDj Dj { get; set; }

        /// <summary>
        ///     Поведение
        /// </summary>
        IBehavior Behavior { get; set; }

        /// <summary>
        ///     Посетители
        /// </summary>
        IList<IDancer> Dancers { get; set; }

        /// <summary>
        ///     Применить поведение
        /// </summary>
        void ApplyBehavior(object sender, ChangeTrackEventArgs eventArgs);
    }
}