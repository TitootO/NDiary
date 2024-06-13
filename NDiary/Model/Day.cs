namespace NDiary.Model
{
	public class Day
	{
		/// <summary>
		/// Обязательная инициализация id студента 
		/// </summary>
		/// <param name="idStudent"></param>
        public Day(int idStudent)
        {
            IdStudent = idStudent;
        }
        /// <summary>
        /// Установки оценки конкретному студенту, дата устанавливается по умолчанию текущая
        /// </summary>
        /// <param name="score"></param>
        /// <param name="idStudent"></param>
        public Day(int? score, int idStudent)
        {
            Score = score;
            IdStudent = idStudent;
        }

        /// <summary>
        /// полная инициализация, для указания точной даты
        /// </summary>
        /// <param name="date"></param>
        /// <param name="score"></param>
        /// <param name="idStudent"></param>
        public Day(DateTime date, int? score, int idStudent)
        {
            this.date = date;
            Score = score;
            IdStudent = idStudent;
        }

        public int Id { get; set; }
		/// <summary>
		/// дата оценки за урок. По умолчанию ствит текущую дату
		/// </summary>
		public DateTime date {  get; set; } = DateTime.Now;
		/// <summary>
		/// Оценка за урок
		/// </summary>
		public int? Score { get; set; }
		/// <summary>
		/// id студента 
		/// </summary>
		public int IdStudent { get; set; }
	}
}
