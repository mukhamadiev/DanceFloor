namespace DanceFloor.Domain.Impl
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using Enum;

    /// <summary>
    ///     Репортер
    /// </summary>
    public class Reporter : IReporter
    {
        private IClub club;
        private Dictionary<ReportType, Func<string, string>> reportTypeMapper;

        /// <inheritdoc />
        public void Init(IClub club)
        {
            this.club = club;
            this.reportTypeMapper = new Dictionary<ReportType, Func<string, string>>
            {
                [ReportType.Track] = this.TrackReport,
                [ReportType.Dancers] = this.DancersReport
            };
        }

        /// <inheritdoc />
        public string Report(ReportType reportType, string parameter)
        {
            if (this.reportTypeMapper.ContainsKey(reportType))
                return this.reportTypeMapper[reportType](parameter);
            return "Информация недоступна";
        }

        private string TrackReport(string parameter)
        {
            return this.club.Dj.CurrentTrack.ToString();
        }

        private string DancersReport(string parameter)
        {
            var dancers = parameter == null ? this.club.Dancers : this.club.Dancers.Where(d => d.Name == parameter);

            var textBuilder = new StringBuilder();

            foreach (var dancer in dancers)
                textBuilder.AppendLine(dancer.ToString());

            return textBuilder.ToString();
        }
    }
}