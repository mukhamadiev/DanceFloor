using DanceFloor.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace DanceFloor.Domain
{
    public interface IReporter
    {
        void Report(ReportType reportType);
    }
}