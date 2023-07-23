namespace RecetteWebAppMVC.Models
{
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    public class Recette
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [DisplayName("Rank")]
        [Range(1, 1000, ErrorMessage = "Display order must be between 1 and 1000 only.")]
        public int DisplayOrder { get; set; }        

        public DateTime CreatedDateTime { get; set; } = DateTime.Now;
    }
}
