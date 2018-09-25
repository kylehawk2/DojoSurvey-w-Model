using System.ComponentModel.DataAnnotations;

namespace DojoSurvey_Model
{
    public class Cat
    {   
        [Required]
        [RegularExpression("^[a-zA-Z]+(([',. -][a-zA-Z ])?[a-zA-Z]*)*$")]
        [MinLength(2)]
        [MaxLength(25)]
        public string Name { get; set; }
        [Required]
        [RegularExpression("^[a-zA-Z]+(([',. -][a-zA-Z ])?[a-zA-Z]*)*$")]
        [MinLength(2)]
        [MaxLength(25)]
        public string Breed { get; set; }
        [Range(0, 150)]
        public double Weight { get; set; }
        [EmailAddress]
        public string OwnerEmail { get; set; }
    }
}