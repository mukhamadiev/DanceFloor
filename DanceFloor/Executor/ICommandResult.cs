namespace DanceFloor.Executor
{
    /// <summary>
    ///     Результат выполнения команды
    /// </summary>
    public interface ICommandResult
    {
        /// <summary>
        ///     Успешность
        /// </summary>
        bool Success { get; set; }

        /// <summary>
        ///     Сообщение
        /// </summary>
        string Message { get; set; }
    }
}