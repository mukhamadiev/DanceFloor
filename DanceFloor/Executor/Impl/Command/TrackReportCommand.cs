namespace DanceFloor.Executor.Impl.Command
{
    using System;
    using Domain;
    using Enum;

    /// <summary>
    ///     Команда отчета о треке
    /// </summary>
    public class TrackReportCommand : ICommand
    {
        private readonly IReporter reporter;

        /// <summary>
        ///     .ctor
        /// </summary>
        /// <param name="reporter">Репортер</param>
        public TrackReportCommand(IReporter reporter)
        {
            this.reporter = reporter;
        }

        /// <inheritdoc />
        public ICommandResult Execute()
        {
            CommandResult result;

            try
            {
                var report = this.reporter.Report(ReportType.Track);

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