namespace DanceFloor.Executor.Impl.Command
{
    using System;
    using Util;

    /// <summary>
    ///     Команда запуска клуба
    /// </summary>
    public class ClubStartCommand : ICommand
    {
        private readonly Emulator emulator;

        /// <summary>
        ///     .ctor
        /// </summary>
        /// <param name="emulator">Эмулятор</param>
        public ClubStartCommand(Emulator emulator)
        {
            this.emulator = emulator;
        }

        /// <inheritdoc />
        public ICommandResult Execute()
        {
            CommandResult result;

            try
            {
                this.emulator.Start();

                result = new CommandResult(true, "Клуб запущен");
            }
            catch (Exception exception)
            {
                result = new CommandResult(false, exception.Message);
            }

            return result;
        }
    }
}