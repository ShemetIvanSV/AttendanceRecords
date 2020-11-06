using AttendanceRecords.Model.DTO;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;

namespace AttendanceRecords.Reports.ReportsRepository
{
    public class SkippedForTeacherRepository : ISkippedRepository
    {
        private readonly IDbConnection _connection;

        public SkippedForTeacherRepository(IDbConnection connection)
        {
            _connection = connection;
        }

        public IEnumerable<SkippedForTeacher> GetData<SkippedForTeacher>(DateTime dataFrom, DateTime dataTo)
        {
            var sql = @"";
            
            var result = _connection.Query<SkippedForTeacher>(sql);

            return result;
        }
    }
}
