using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace ForgingAhead.Models {
    
    public class Quest {

        [Required(ErrorMessage = "Name is required")]
        [Key]
        [MinLength(3, ErrorMessage = "Name must be at least 3 characters long")]
        public string Name { get; set; }

        [DisplayAttribute(Name="Is Active")]
        public bool IsActive { get; set; }

        public List<Character> Characters { get; set; } = new List<Character>();
    }
}