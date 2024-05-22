namespace TrashTracker.Model
{
	public class TrashPin
    {
        public TrashPin(int id, string name, string description, Location location, string image, Severity severity, int reportedBy, DateTime reportedOn, int? cleanedBy = null, DateTime? cleanedOn = null) : this()
        {
            Id = id;
            Name = name;
            Description = description;
            Location = location;
            Image = image;
            Severity = severity;
            ReportedBy = reportedBy;
            ReportedOn = reportedOn;
            CleanedBy = cleanedBy;
            CleanedOn = cleanedOn;
        }

        public TrashPin(string name, string description, Location location, Severity severity, int reportedBy)
        {
            Name = name;
            Description = description;
            Location = location;
            Severity = severity;
            ReportedBy = reportedBy;
            ReportedOn = DateTime.Now;
        }


        public TrashPin()
        {
            
        }

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

