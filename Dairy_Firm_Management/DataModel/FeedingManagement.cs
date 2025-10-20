namespace Dairy_Firm_Management.DataModel
{
    public class FeedingManagement
    {
        public Guid Feeding_Id { get; set; } = Guid.NewGuid();
        public int Cow_Id { get; set; }
        public string Food_Type { get; set; }
        public DateTime Feeding_Time { get; set; }
        public double Feeding_Quantity { get; set; }

    }
}


