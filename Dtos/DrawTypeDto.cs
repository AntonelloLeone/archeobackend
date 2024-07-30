using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Dtos
{
    public class DrawTypeDto
    {
        public long Id { get; set; }
        [Required]
        public string? Name { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }

}
