using System.ComponentModel.DataAnnotations;


namespace ForgingAhead.Models {
    public class Equipment 
    {
        [Key]
        public string Name { get; set; }
    }
}