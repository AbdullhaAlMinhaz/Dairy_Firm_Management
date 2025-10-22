using System.ComponentModel.DataAnnotations;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Dairy_Firm_Management.DataModel
{
    public class MeatProductionTracking
    {
        [Key]
        public Guid MeatId { get; set; }
        public Guid CowId { get; set; }
        public DateTime WeightDate { get; set; }
        public double Weight { get; set; }


    }
}
