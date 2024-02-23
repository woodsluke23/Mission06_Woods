using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;

namespace Mission06_Woods.Models
{
    public class Movie
    {
        [Key]
        [Required]
        public int MovieId { get; set; } //Required

        [ForeignKey("CategoryId")]
        public int? CategoryId { get; set; }
        public Category? Category { get; set; }


        [Required(ErrorMessage = "Please enter the title")]
        public string? Title { get; set; } //Required


        [Required(ErrorMessage = "Please enter the year the movie was published")]
        public string? Year { get; set; } //Required
        public string? Director { get; set; }
        public string? Rating { get; set; }


        [Required(ErrorMessage = "Please enter if the movie was edited or not")]
        public bool Edited { get; set; } //Required
        public string? LentTo { get; set; }


        [Required(ErrorMessage = "Please enter if the movie was copied to plex or not")]
        public bool CopiedToPlex { get; set; } //Required
        public string? Notes { get; set;}

    }
}
