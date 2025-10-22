using System.ComponentModel.DataAnnotations;

namespace Dairy_Firm_Management.DataModel
{
    public class CowInventory
    {
        [Key]
        public Guid CowId { get; set; } 
        //public int Cow_Id { get; set; }
        public DateTime DateOfBirth { get; set; } = DateTime.UtcNow;
        public string? Gender { get; set; } 
        public double Weight { get; set; }
        public double Price { get; set; }
        public string? Breed { get; set; } // there ? refers to null string
        public DateTime EntryDate { get; set; }


    }
}

