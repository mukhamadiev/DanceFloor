namespace DanceFloor.Executor.Impl.Command
{
    using System;
    using Util;

    /// <summary>
    ///     Команда переключения трека
    /// </summary>
    public class NextTrackCommand : ICommand
    {
        private readonly Emulator emulator;

        /// <summary>
        ///     .ctor
        /// </summary>
        /// <param name="emulator">Эмулятор</param>
        public NextTrackCommand(Emulator emulator)
        {
            this.emulator = emulator;
        }

        /// <inheritdoc />
        public ICommandResult Execute()
        {
            CommandResult result;

            try
            {
                this.emulator.Club.Dj.NextTrack();

                result = new CommandResult(true, "Трек переключен");
            }
            catch (Exception exception)
            {
                result = new CommandResult(false, exception.Message);
            }

            return result;
        }
    }
}