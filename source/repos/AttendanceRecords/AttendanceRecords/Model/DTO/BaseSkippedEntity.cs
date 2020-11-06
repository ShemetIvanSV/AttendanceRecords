namespace AttendanceRecords.Model.DTO
{
    public class BaseSkippedEntity
    {
        /// <summary>
        /// Пропущенно часов
        /// </summary>
        public int MissedHours { get; set; }

        /// <summary>
        /// Количество пропусков
        /// </summary>
        public int CountPasses { get; set; }

        /// <summary>
        /// Всего кол-во часов
        /// </summary>
        public int SummHours { get; set; }
    }
}
