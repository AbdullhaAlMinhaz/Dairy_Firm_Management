namespace Dairy_Firm_Management.ViewModel
{
    public class FeedingManagementVM
    {
        public Guid FeedingId { get; set; }
        public Guid CowId { get; set; }
        public string? FoodType { get; set; }
        public DateTime FeedingTime { get; set; }
        public double FeedingQuantity { get; set; }
    }
}
