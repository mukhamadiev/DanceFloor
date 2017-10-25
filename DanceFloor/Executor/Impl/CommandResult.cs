namespace DanceFloor.Executor.Impl
{
    /// <summary>
    ///     Результат выполнения команды
    /// </summary>
    public class CommandResult : ICommandResult
    {
        /// <summary>
        ///     .ctor
        /// </summary>
        /// <param name="success">Успешность</param>
        /// <param name="message">Сообщение</param>
        public CommandResult(bool success, string message)
        {
            this.Success = success;
            this.Message = message;
        }

        /// <inheritdoc />
        public bool Success { get; set; }

        /// <inheritdoc />
        public string Message { get; set; }
    }
}