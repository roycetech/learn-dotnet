using System.ComponentModel.DataAnnotations;


namespace ForgingAhead.Models {

    public class Equipment 
    {
        [Required(ErrorMessage = "Name is required")]
        [Key]
        [MinLength(3, ErrorMessage = "Name must be at least 3 characters long")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Attack is required")]
        [DisplayAttribute(Name="Att")]
        [Range(1, 10, ErrorMessage = "Attack must be between 1 and 10")]
        public int? Attack { get; set; }
        
        [Required(ErrorMessage = "Defense is required")]
        [Range(1, 10, ErrorMessage = "Defense must be between 1 and 10")]
        [DisplayAttribute(Name="Def")]
        public int? Defense { get; set; }
    }
}