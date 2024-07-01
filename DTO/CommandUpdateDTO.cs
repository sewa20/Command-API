using System.ComponentModel.DataAnnotations;

namespace Practice2.DTO
{
    public class CommandUpdateDTO
    {
        [Required]
        [MaxLength(250)]
        public string? HowTo { get; set; }

        [Required]
        public string? Line { get; set; }

        [Required]
        public string? PlatForm { get; set; }
    }
}
