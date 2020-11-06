namespace AttendanceRecords.Model.DTO
{
    /// <summary>
    /// Пропущено по предметам
    /// </summary>
    public class SkippedForScoolSubject : BaseSkippedEntity
    {
        /// <summary>
        /// Название предмета
        /// </summary>
        public string SubjectName { get; set; }
    }
}
