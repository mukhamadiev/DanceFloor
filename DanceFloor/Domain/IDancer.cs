namespace DanceFloor.Domain
{
    using System.Collections.Generic;
    using Enum;

    /// <summary>
    ///     Посетитель
    /// </summary>
    public interface IDancer
    {
        /// <summary>
        ///     Имя
        /// </summary>
        string Name { get; set; }

        /// <summary>
        ///     Пол
        /// </summary>
        Sex Sex { get; set; }

        /// <summary>
        ///     Доступные танцы
        /// </summary>
        IList<IDance> AvailableDances { get; set; }

        /// <summary>
        ///     Состояние
        /// </summary>
        State State { get; set; }

        /// <summary>
        ///     Текущий танец
        ///     <para>Если текущее состояние Танец</para>
        /// </summary>
        IDance CurrentDance { get; set; }
    }
}