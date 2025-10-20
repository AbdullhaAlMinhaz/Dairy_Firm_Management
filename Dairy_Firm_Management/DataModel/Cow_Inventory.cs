using System.ComponentModel.DataAnnotations;

namespace Dairy_Firm_Management.DataModel
{
    public class Cow_Inventory
    {
        public Guid Cow_Id { get; set; } = Guid.NewGuid();
        //public int Cow_Id { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Gender { get; set; }
        public double Weight { get; set; }
        public double Price { get; set; }
        public string Breed { get; set; }
        public DateTime EntryDate { get; set; }


    }
}

