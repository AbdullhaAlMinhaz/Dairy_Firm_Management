namespace Dairy_Firm_Management.ViewModel
{
    public class VaccineInventoryVM
    {
        public Guid VaccineId { get; set; }
        public string? VaccineName { get; set; }
        public double VaccinePrice { get; set; }
        public int TotalVaccine { get; set; }
        public string? VaccineMonth { get; set; }
        public string? VaccineDay { get; set; }
    }
}
