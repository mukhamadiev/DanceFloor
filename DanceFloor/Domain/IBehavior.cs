namespace DanceFloor.Domain
{
    /// <summary>
    ///     Поведение
    /// </summary>
    public interface IBehavior
    {
        /// <summary>
        ///     Название
        /// </summary>
        string Name { get; }

        /// <summary>
        ///     Применить
        /// </summary>
        /// <param name="behaviorContext">Контекст поведения</param>
        /// <param name="dancer">Посетитель</param>
        void Apply(IBehaviorContext behaviorContext, IDancer dancer);
    }
}