namespace Dairy_Firm_Management.DataModel
{
    public class Milk_Production_Tracking
    {
        public int Milk_Id { get; set; }
        public int Cow_Id { get; set; }
        public DateTime MilkDate { get; set; }
        public double MorningMilk { get; set; }
        public double EveningMilk { get; set; }
    }
}
