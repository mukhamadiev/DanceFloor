namespace DanceFloor.Executor
{
    /// <summary>
    ///     Команда
    /// </summary>
    public interface ICommand
    {
        /// <summary>
        ///     Выполнить
        /// </summary>
        ICommandResult Execute();
    }
}