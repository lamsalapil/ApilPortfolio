using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApilPortfolio.Models.AdminModels
{
    public class ProjectModel
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string ProjectName { get; set; }

        [Required]
        public string Description { get; set; }

        [DisplayName("Image Name")]
        public string? Image { get; set; }

        [NotMapped]
        [DisplayName("Upload Image")]
        public IFormFile ImagePath { get; set; }

    }
}
