namespace Dairy_Firm_Management.DataModel
{
    public class Vaccine_Inventory
    {
        public Guid Vaccine_Id { get; set; } = Guid.NewGuid();
        public string VaccineName { get; set; }
        public double VaccinePrice { get; set; }
        public int TotalVaccine { get; set; }
        public string VaccineMonth { get; set; }
        public string VaccineDay { get; set; }

    }
}
