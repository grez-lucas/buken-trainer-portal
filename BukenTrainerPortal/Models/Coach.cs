namespace BukenTrainerPortal.Models
{
    public class Coach
    {
        public int ID { get; set; }
        public required string FirstName { get; set; }
        public required string LastName { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public ICollection<CheckIn>? CheckIns { get; set; }
    }
}
