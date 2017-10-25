namespace DanceFloor.Domain
{
    using Enum;

    /// <summary>
    ///     Репортер
    /// </summary>
    public interface IReporter
    {
        /// <summary>
        ///     Инициализировать
        /// </summary>
        /// <param name="club">Клуб</param>
        void Init(IClub club);

        /// <summary>
        ///     Отчет
        /// </summary>
        /// <param name="reportType">Тип отчета</param>
        /// <param name="parameter">Параметр</param>
        string Report(ReportType reportType, string parameter = null);
    }
}