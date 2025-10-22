namespace Dairy_Firm_Management.ViewModel
{
    public class MilkProductionTrackingVM
    {
        public int MilkId { get; set; }
        public Guid CowId { get; set; }
        public DateTime MilkDate { get; set; }
        public double MorningMilk { get; set; }
        public double EveningMilk { get; set; }
    }
}
