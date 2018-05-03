using SQLite;
using System;

namespace weeklyplanner.Models
{
    public class Item
    {
		[PrimaryKey, AutoIncrement]
		public int Id { get; set; }
        public string Title { get; set; }
        public string Notes { get; set; }
		public DateTime Date { get; set; }
		public int StartHour { get; set; }
		public int Duration { get; set; }	

		public string UserId { get; set; }
	}
}