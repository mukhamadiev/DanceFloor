namespace DanceFloor.Executor.Impl
{
    /// <summary>
    ///     Клиент
    /// </summary>
    public class Client : IClient
    {
        private ICommand command;

        /// <inheritdoc />
        public ICommandResult Execute()
        {
            return this.command?.Execute();
        }

        /// <inheritdoc />
        public void SetCommand(ICommand command)
        {
            this.command = command;
        }
    }
}