using System.ComponentModel.DataAnnotations;

namespace Dairy_Firm_Management.DataModel
{
    public class VaccineInventory
    {
        [Key]
        public Guid VaccineId { get; set; } 
        public string? VaccineName { get; set; }
        public double VaccinePrice { get; set; }
        public int TotalVaccine { get; set; }
        public string? VaccineMonth { get; set; }
        public string? VaccineDay { get; set; }

    }
}
