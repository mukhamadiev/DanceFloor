namespace DanceFloor.Domain.Impl
{
    using Enum;
    using Util;

    /// <summary>
    ///     Движение
    /// </summary>
    public class Motion : IMotion
    {
        /// <inheritdoc />
        public BodyPart BodyPart { get; set; }

        /// <inheritdoc />
        public string Description { get; set; }

        /// <inheritdoc />
        public override string ToString()
        {
            return $"{this.BodyPart.GetDescription()}: {this.Description}";
        }
    }
}