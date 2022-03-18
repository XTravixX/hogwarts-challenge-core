using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace hogwarts_challenge_core.Models
{
    public class Applicant
    {
        [Required]
        [Range(1, 9999999999)]
        public int ApplicantId { get; set; }

        [Required]
        [StringLength(
            20,
            MinimumLength = 3,
            ErrorMessage = "Name support max 20 characters and minimum 3"
        )]
        [RegularExpression(
            @"^[a-zA-Z\s]*$",
            ErrorMessage = "Name should be have alphabetical characters"
        )]
        public string Name { get; set; }

        [StringLength(20, MinimumLength = 3)]
        [RegularExpression(
            @"^[a-zA-Z\s]*$",
            ErrorMessage = "LastName should be have alphabetical characters"
        )]
        public string LastName{ get; set; }

        [Range(1, 99)]
        public int Age{ get; set; } 

        [Required]
        [RegularExpression(
            @"(Gryffindor)|(Hufflepuff)|(Ravenclaw)|(Slytherin)",
            ErrorMessage = "Only Houses available are Gryffindor, Ravenclaw, Slytherin, and Hufflepuff"
        )]
        public string House{ get; set; }
    }
}