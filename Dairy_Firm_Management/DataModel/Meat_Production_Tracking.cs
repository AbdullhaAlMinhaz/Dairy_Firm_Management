using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Dairy_Firm_Management.DataModel
{
    public class Meat_Production_Tracking
    {
          public Guid Meat_Id { get; set; } = Guid.NewGuid();
          public int Cow_Id { get; set; }
          public DateTime WeightDate { get; set; }
          public double Weight { get; set; }


    }
}
