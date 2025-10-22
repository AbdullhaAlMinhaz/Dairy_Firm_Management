namespace Dairy_Firm_Management.ViewModel
{
    public class MeatProductionTrackingVM
    {
        public Guid MeatId { get; set; }
        public Guid CowId { get; set; }
        public DateTime WeightDate { get; set; }
        public double Weight { get; set; }
    }
}
