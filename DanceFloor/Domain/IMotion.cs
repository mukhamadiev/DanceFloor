namespace DanceFloor.Domain
{
    using Enum;

    /// <summary>
    ///     Движение
    /// </summary>
    public interface IMotion
    {
        /// <summary>
        ///     Часть тела
        /// </summary>
        BodyPart BodyPart { get; set; }

        /// <summary>
        ///     Описание движения
        /// </summary>
        string Description { get; set; }
    }
}