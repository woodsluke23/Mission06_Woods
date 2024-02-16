using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace Mission06_Woods.Models
{
    public class Application
    {
        [Key]
        [Required]
        public required int ApplicationID { get; set; }

        [Required]
        public required string MovieCategory { get; set; }

        public string? MovieSubCategory { get; set; }

        [Required]
        public required string MovieName { get; set; }

        [Required]
        public required string ReleaseYear { get; set; }

        [Required]
        public required string Director { get; set; }

        [Required]
        public required string Rating { get; set; }  
        public bool? Edited { get; set; }
        public string? LentTo { get; set; }
        public string? Notes { get; set;}

    }
}
