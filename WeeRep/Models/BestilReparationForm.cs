using System.ComponentModel.DataAnnotations;

namespace WeeRep.Models
{
    public class BestilReparationForm
    {
        [Required]
        public string Name { get; set; }
        [Required]
        [RegularExpression(@"^([A-Za-z0-9][^'!&\\#*$%^?<>()+=:;`~\[\]{}|/,₹€@ ][a-zA-z0-9-._][^!&\\#*$%^?<>()+=:;`~\[\]{}|/,₹€@ ]*\@[a-zA-Z0-9][^!&@\\#*$%^?<> ()+=':;~`.\[\]{}|/,₹€ ]*\.[a-zA-Z]{2,6})$", ErrorMessage = "Please enter a valid Email Example@Example.Example")]
        public string Email { get; set; }

        public string Message { get; set; }

        [DataType(DataType.PhoneNumber)]
        [Required(ErrorMessage = "Phone Number Required!")]
        [RegularExpression(@"^[0-9]{8}$", ErrorMessage = "Entered phone format @Ex (8 Nr).")]
        public string Mobil { get; set; }
        [Required]
        public string Dag { get; set; }
        [Required]
        public string TimeFrom { get; set; }
        [Required]
        public string TimeEnd { get; set; }
        [Required]
        public string PhonModel { get; set; }
    }
}