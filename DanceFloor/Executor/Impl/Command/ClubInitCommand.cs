namespace DanceFloor.Executor.Impl.Command
{
    using System;
    using Util;

    /// <summary>
    ///     Команда инициализации клуба
    /// </summary>
    public class ClubInitCommand : ICommand
    {
        private readonly Emulator emulator;

        /// <summary>
        ///     .ctor
        /// </summary>
        /// <param name="emulator">Эмулятор</param>
        public ClubInitCommand(Emulator emulator)
        {
            this.emulator = emulator;
        }

        /// <inheritdoc />
        public ICommandResult Execute()
        {
            CommandResult result;

            try
            {
                this.emulator.Init();

                result = new CommandResult(true, "Клуб инициализирован");
            }
            catch (Exception exception)
            {
                result = new CommandResult(false, exception.Message);
            }

            return result;
        }
    }
}