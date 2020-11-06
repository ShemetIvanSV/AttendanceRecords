using AttendanceRecords.Model.DTO;
using AttendanceRecords.Model.ReportsRepository;
using AttendanceRecords.Reports.ReportsRepository;
using System.Collections.Generic;
using System.Data;

namespace AttendanceRecords.Reports
{
    public class SkippingClassReport
    {
        private readonly IDbConnection _connection;
        private ISkippedRepository _repository;

        private IEnumerable<BaseSkippedEntity> _skippeds;

        public SkippingClassReport(IDbConnection connection)
        {
            _connection = connection;
        }

        public IEnumerable<BaseSkippedEntity> GetReport(SkippedFlags flags)
        {
            if (flags.IsSkippedForClass)
                _repository = new SkippedForClassRepository(_connection);

            if (flags.IsSkippedForSchoolSubject)
                _repository = new SkippedForSchoolSubjectRepository(_connection);

            if (flags.IsSkippedForTeacher)
                _repository = new SkippedForTeacherRepository(_connection);

            _skippeds = _repository.GetData<BaseSkippedEntity>(flags.DateTimeFrom, flags.DateTimeTo);

            return _skippeds;
        }

        public int GetPercentSkipped()
        {
            var allMissedHours = 0;
            var allSummHours = 0; 

            foreach (var skipped in _skippeds)
            {
                allMissedHours += skipped.MissedHours;
                allSummHours += skipped.SummHours;
            }

            return (allMissedHours / allSummHours) * 100;
        }
    }
}
