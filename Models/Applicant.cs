using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace hogwarts_challenge_core.Models
{
    public class Applicant
    {
        [Required]
        [Range(1, 9999999999)]
        public int applicantId { get; set; }

        [Required]
        [StringLength(
            20,
            MinimumLength = 3,
            ErrorMessage = "El nombre debe contener minimo 3 caracteres y maximo 20"
        )]
        [RegularExpression(
            @"^[a-zA-Z\s]*$",
            ErrorMessage = "El nombre debe contener solo caracteres numericos"
        )]
        public string name { get; set; }

        [StringLength(20, MinimumLength = 3)]
        [RegularExpression(
            @"^[a-zA-Z\s]*$",
            ErrorMessage = "El apellido debe contener solo caracteres numericos"
        )]
        public string lastName{ get; set; }

        [Range(1, 99)]
        public int age{ get; set; } 

        [Required]
        [RegularExpression(
            @"(Gryffindor)|(Hufflepuff)|(Ravenclaw)|(Slytherin)",
            ErrorMessage = "Las casas habilitadas son: Gryffindor, Ravenclaw, Slytherin, and Hufflepuff"
        )]
        public string house{ get; set; }
    }
}