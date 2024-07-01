using System.ComponentModel.DataAnnotations;

namespace Practice2.Models
{
    public class Command
    {
            [Key]
            public int Id { get; set; }

            [Required]
            [MaxLength(250)]
            public string? HowTo { get; set; }

            [Required]
            public string? Line { get; set; }

            [Required]
            public string? PlatForm { get; set; }

        
    }
}
