namespace DanceFloor.Enum
{
    using System.ComponentModel;

    /// <summary>
    ///     Часть тела
    /// </summary>
    public enum BodyPart
    {
        [Description("Торс")] Torso,

        [Description("Голова")] Head,

        [Description("Руки")] Arm,

        [Description("Ноги")] Leg
    }
}