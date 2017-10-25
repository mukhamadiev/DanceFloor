namespace DanceFloor.Domain.Impl
{
    using System.Collections.Generic;
    using EventArg;

    /// <summary>
    ///     Клуб
    /// </summary>
    public class Club : IClub
    {
        /// <inheritdoc />
        public string Name { get; set; }

        /// <inheritdoc />
        public IDj Dj { get; set; }

        /// <inheritdoc />
        public IBehavior Behavior { get; set; }

        /// <inheritdoc />
        public IList<IDancer> Dancers { get; set; }

        /// <inheritdoc />
        public void ApplyBehavior(object sender, ChangeTrackEventArgs eventArgs)
        {
            foreach (var dancer in this.Dancers)
                this.Behavior.Apply(eventArgs.BehaviorContext, dancer);
        }

        /// <inheritdoc />
        public override string ToString()
        {
            return $"Клуб: {this.Name}";
        }
    }
}