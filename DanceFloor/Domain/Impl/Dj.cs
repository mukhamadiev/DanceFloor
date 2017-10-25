namespace DanceFloor.Domain.Impl
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using EventArg;
    using Util;

    /// <summary>
    ///     Диджей
    /// </summary>
    public class Dj : IDj
    {
        /// <inheritdoc />
        public string Name { get; set; }

        /// <inheritdoc />
        public IList<ITrack> Tracks { get; set; }

        /// <inheritdoc />
        public ITrack CurrentTrack { get; set; }

        /// <inheritdoc />
        public EventHandler<ChangeTrackEventArgs> ChangedHandler { get; set; }

        /// <inheritdoc />
        public void NextTrack()
        {
            var tracks = this.Tracks.Where(t => t != this.CurrentTrack).ToList();

            this.CurrentTrack = RandomHelper.GetRandomElement(tracks);

            this.CallHandler();
        }

        private void CallHandler()
        {
            var arguments = new ChangeTrackEventArgs
            {
                BehaviorContext = new BehaviorContext(this.CurrentTrack.Genre)
            };

            this.ChangedHandler.Invoke(this, arguments);
        }
    }
}