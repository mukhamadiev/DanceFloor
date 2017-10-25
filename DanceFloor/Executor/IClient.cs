namespace DanceFloor.Executor
{
    /// <summary>
    ///     Клиент
    /// </summary>
    public interface IClient
    {
        /// <summary>
        ///     Задать команду
        /// </summary>
        /// <param name="command">Команда</param>
        void SetCommand(ICommand command);

        /// <summary>
        ///     Выполнить команду
        /// </summary>
        ICommandResult Execute();
    }
}