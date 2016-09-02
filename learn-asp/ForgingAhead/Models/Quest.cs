using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace ForgingAhead.Models {
    
    public class Quest {
    
        [MinLength(3)]
        [Required]
        [Key]
        public string Name { get; set; }

        [Required]
        [DisplayAttribute(Name="Is Active")]
        public bool IsActive { get; set; }

        public List<Character> Characters { get; set; } = new List<Character>();
    }
}