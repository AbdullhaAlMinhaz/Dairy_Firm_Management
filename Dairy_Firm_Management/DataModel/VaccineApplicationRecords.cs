using System.ComponentModel.DataAnnotations;

namespace Dairy_Firm_Management.DataModel
{
    public class VaccineApplicationRecords
    {
        [Key]
        public Guid VaccineApplyId { get; set; }
        public Guid CowId { get; set; }
        public Guid VaccineId { get; set; }
        public double VaccineApplyAmount { get; set; }
        public string? VaccineApplyMonth {  get; set; }
        public string? VaccineApplyDay { get; set; }
    }
}
