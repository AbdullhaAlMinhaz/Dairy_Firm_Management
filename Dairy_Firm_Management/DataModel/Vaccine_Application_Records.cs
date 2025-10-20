namespace Dairy_Firm_Management.DataModel
{
    public class Vaccine_Application_Records
    {
        public Guid VaccineApplyId { get; set; } = Guid.NewGuid();
        public int Cow_Id { get; set; }
        public int Vaccine_Id { get; set; }
        public double VaccineApplyAmount { get; set; }
        public string VaccineApplyMonth {  get; set; }
        public string VaccineApplyDay { get; set; }
    }
}
