using System;
using System.Collections.Generic;

namespace AttendanceRecords.Model.DTO
{
    public interface ISkippedRepository
    {
        IEnumerable<T> GetData<T>(DateTime dateTimeFrom, DateTime dateTimeTo) where T : BaseSkippedEntity;
    }
}
