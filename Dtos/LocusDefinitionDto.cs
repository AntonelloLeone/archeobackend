using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Dtos
{
    public class LocusDefinitionDto
    {
        public long Id { get; set; }
        [Required(ErrorMessage = "Il campo Name è obbligatorio.")]
        public string? Name { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime UpdatedAt { get; set; }
    }
}
