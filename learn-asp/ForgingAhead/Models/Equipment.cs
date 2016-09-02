using System.ComponentModel.DataAnnotations;


namespace ForgingAhead.Models {
    public class Equipment 
    {
        [Key]
        public string Name { get; set; }

        [DisplayAttribute(Name="Att")]
        public int attack { get; set; }
        [DisplayAttribute(Name="Def")]
        public int defense { get; set; }
    }
}