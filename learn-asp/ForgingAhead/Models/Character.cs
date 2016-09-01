using System.ComponentModel.DataAnnotations;


namespace  ForgingAhead.Models {
    public class Character {
        [Key]
        public string Name { get; set; }
        [DisplayAttribute(Name="Is Active")]
        public bool IsActive { get; set; }
        public int Level { get; set; }
        public int Strength { get; set; }
        public int Dexterity { get; set; }
        public int Intelligence { get; set; }
    } 
}