namespace TrashTracker.Model
{
	public class TrashPin
    {
        public int? Id { get; set; }
        public string? Name { get; set; }
		public string? Description { get; set; }
        public Location? Location { get; set; }
		public string? Image { get; set; }
		public Severity? Severity { get; set; }
		public int? ReportedBy { get; set; }
		public DateTime? ReportedOn { get; set; }
		public int? CleanedBy { get; set; }
		public DateTime? CleanedOn { get; set; }
	}
}

