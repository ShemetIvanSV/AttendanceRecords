using AttendanceRecords.Model.DTO;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;

namespace AttendanceRecords.Model.ReportsRepository
{
    public class SkippedForSchoolSubjectRepository : ISkippedRepository
    {
        private readonly IDbConnection _connection;

        public SkippedForSchoolSubjectRepository(IDbConnection connection)
        {
            _connection = connection;
        }

        public IEnumerable<SkippedForSchoolSubject> GetData<SkippedForSchoolSubject>(DateTime dataFrom, DateTime dataTo)
        {
            var sql = @"";

            var result = _connection.Query<SkippedForSchoolSubject>(sql);

            return result;
        }
    }
}
