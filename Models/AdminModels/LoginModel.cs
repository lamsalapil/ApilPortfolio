using System.ComponentModel.DataAnnotations;

namespace ApilPortfolio.Models.AdminModels
{
    public class LoginModel
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        [StringLength(50)]
        [DataType(DataType.Password)]
        public string Password { get; set; }

     
    }
}
