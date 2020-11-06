using System;

namespace AttendanceRecords.Reports
{
    public class SkippedFlags
    {
        public bool IsSkippedForClass { get; }
        public bool IsSkippedForSchoolSubject { get; }
        public bool IsSkippedForTeacher { get; }
        public DateTime DateTimeFrom { get; }
        public DateTime DateTimeTo { get; }

        public SkippedFlags(bool isSkippedForClass, bool isSkippedForScoolSubject,
                            bool isSkippedForTeacher, DateTime dateTimeFrom,
                            DateTime dateTimeTo)
        {
            IsSkippedForClass = isSkippedForClass;
            IsSkippedForSchoolSubject = isSkippedForScoolSubject;
            IsSkippedForTeacher = isSkippedForTeacher;
            DateTimeFrom = dateTimeFrom;
            DateTimeTo = dateTimeTo;
        }
    }
}
