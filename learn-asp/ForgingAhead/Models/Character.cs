using System.ComponentModel.DataAnnotations;


namespace  ForgingAhead.Models {

    public class Character {

        [Required(ErrorMessage = "Name is required")]
        [Key]
        [MinLength(3, ErrorMessage = "Name must be at least 3 characters long")]
        public string Name { get; set; }

        [DisplayAttribute(Name = "Is Active")]
        [Required(ErrorMessage = "Is Active is required")]
        public bool IsActive { get; set; }

        [Range(1, 20, ErrorMessage = "Level must be between 1 and 20")]
        [Required(ErrorMessage = "Level is required")]
        public int? Level { get; set; }

        [Required(ErrorMessage = "Strength is required")]
        [Range(1, 10, ErrorMessage = "Strength must be between 1 and 10")]
        public int? Strength { get; set; }

        [Required(ErrorMessage = "Dexterity is required")]
        [Range(1, 10, ErrorMessage = "Dexterity must be between 1 and 10")]
        public int? Dexterity { get; set; }

        [Required(ErrorMessage = "Intelligence is required")]
        [Range(1, 10, ErrorMessage = "Intelligence must be between 1 and 10")]
        public int? Intelligence { get; set; }
    } 
}