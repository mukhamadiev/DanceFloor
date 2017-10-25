namespace DanceFloor.EventArg
{
    using System;
    using Domain;

    /// <summary>
    ///     Аргументы обработчика
    /// </summary>
    public class ChangeTrackEventArgs : EventArgs
    {
        /// <summary>
        ///     Контекст поведения
        /// </summary>
        public IBehaviorContext BehaviorContext { get; set; }
    }
}