namespace BukenTrainerPortal.Models
{
    public class CheckIn
    {
        public int ID { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public required Athlete Athlete { get; set; }
        public required Coach Coach { get; set; }
    }
}
