namespace DanceFloor.Executor.Impl.Command
{
    using System;
    using Domain;
    using Enum;

    /// <summary>
    ///     Команда отчета о посетителях
    /// </summary>
    public class DancersReportCommand : ICommand
    {
        private readonly string parameter;
        private readonly IReporter reporter;

        /// <summary>
        ///     .ctor
        /// </summary>
        /// <param name="reporter">Репортер</param>
        /// <param name="parameter">Параметр</param>
        public DancersReportCommand(IReporter reporter, string parameter = null)
        {
            this.reporter = reporter;
            this.parameter = parameter;
        }

        /// <inheritdoc />
        public ICommandResult Execute()
        {
            CommandResult result;

            try
            {
                var report = this.reporter.Report(ReportType.Dancers, this.parameter);

                result = new CommandResult(true, report);
            }
            catch (Exception exception)
            {
                result = new CommandResult(false, exception.Message);
            }

            return result;
        }
    }
}