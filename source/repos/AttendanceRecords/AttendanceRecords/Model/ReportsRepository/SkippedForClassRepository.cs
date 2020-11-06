using AttendanceRecords.Model.DTO;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;

namespace AttendanceRecords.Model.ReportsRepository
{
    public class SkippedForClassRepository : ISkippedRepository
    {
        private readonly IDbConnection _connection;

        public SkippedForClassRepository(IDbConnection connection)
        {
            _connection = connection;
        }

        public IEnumerable<SkippedForClass> GetData<SkippedForClass>(DateTime dataFrom, DateTime dataTo)
        {
            var sql = @"";

            var result = _connection.Query<SkippedForClass>(sql);

            return result;
        }
    }
}
