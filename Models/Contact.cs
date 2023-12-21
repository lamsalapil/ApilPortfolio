using System.ComponentModel.DataAnnotations;

namespace ApilPortfolio.Models
{
    public class Contact
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        
        public string Massages { get; set; }

        
    }
}
