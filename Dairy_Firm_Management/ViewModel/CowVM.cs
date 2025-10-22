namespace Dairy_Firm_Management.ViewModel
{
    public class CowVM
    {
        public Guid CowId { get; set; }
        public DateTime DateOfBirth { get; set; } = DateTime.UtcNow;
        public string? Gender { get; set; }
        public double Weight { get; set; }
        public double Price { get; set; }
        public string? Breed { get; set; } 
        public DateTime EntryDate { get; set; }
    }
}
