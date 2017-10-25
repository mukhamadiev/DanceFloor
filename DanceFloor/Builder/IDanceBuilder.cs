namespace DanceFloor.Builder
{
    using Domain;

    /// <summary>
    ///     Строитель для <see cref="IDance" />
    /// </summary>
    public interface IDanceBuilder
    {
        /// <summary>
        ///     Создать
        /// </summary>
        IDanceBuilder Create();

        /// <summary>
        ///     Задать название
        /// </summary>
        /// <param name="name">Название</param>
        IDanceBuilder Name(string name);

        /// <summary>
        ///     Задать движение туловищем
        /// </summary>
        /// <param name="description">Описание движения</param>
        IDanceBuilder TorsoMotion(string description);

        /// <summary>
        ///     Задать движение головой
        /// </summary>
        /// <param name="description">Описание движения</param>
        IDanceBuilder HeadMotion(string description);

        /// <summary>
        ///     Задать движение руками
        /// </summary>
        /// <param name="description">Описание движения</param>
        IDanceBuilder ArmMotion(string description);

        /// <summary>
        ///     Задать движение ногами
        /// </summary>
        /// <param name="description">Описание движения</param>
        IDanceBuilder LegMotion(string description);

        /// <summary>
        ///     Задать доступный жанр
        /// </summary>
        /// <param name="genre">Описание движения</param>
        IDanceBuilder AvailableGenre(IGenre genre);

        /// <summary>
        ///     Построить
        /// </summary>
        IDance Build();
    }
}