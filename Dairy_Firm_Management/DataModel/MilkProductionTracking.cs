using System.ComponentModel.DataAnnotations;

namespace Dairy_Firm_Management.DataModel
{
    public class MilkProductionTracking
    {
        [Key]
        public int MilkId { get; set; }
        public Guid CowId { get; set; }
        public DateTime MilkDate { get; set; }
        public double MorningMilk { get; set; }
        public double EveningMilk { get; set; }
    }
}
