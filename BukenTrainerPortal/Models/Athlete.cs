namespace BukenTrainerPortal.Models
{
    public class Athlete
    {
        public int ID { get; set; }
        public required string FirstName { get; set; }
        public required string LastName { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public ICollection<CheckIn>? CheckIns { get; set; }

        // Foreign key property
        public int CoachId { get; set; }

        // Navigation property to the coach
        public Coach Coach { get; set; }
    }
}
