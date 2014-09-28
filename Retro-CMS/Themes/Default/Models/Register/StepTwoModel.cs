using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Common.Filters;
using Retro_CMS.Infrastructure.Mapping;

namespace Default.Models.Register
{
    public class StepTwoModel : StepOneModel, IMapFrom<StepOneModel>
    {
        [Required(ErrorMessage = "The field {0} is required")]
        [StringLength(15, MinimumLength = 5, ErrorMessage = "The field {0} must contain between the {1} and {2} characters")]
        public string Username { get; set; }

        [Required(ErrorMessage = "The field {0} is required")]
        [EmailAddress]
        [StringLength(50, MinimumLength = 5, ErrorMessage = "The field {0} must contain between the {1} and {2} characters")]
        public string Email { get; set; }

        [Required(ErrorMessage = "The field {0} is required")]
        [EmailAddress]
        [StringLength(50, MinimumLength = 5, ErrorMessage = "The field {0} must contain between the {1} and {2} characters")]
        [Compare("Email", ErrorMessage = "The fields {0} and {1} don't match")]
        [DisplayName("Repeat Email")]
        public string RepeatEmail { get; set; }

        [Required(ErrorMessage = "The field {0} is required")]
        [StringLength(25, MinimumLength = 5, ErrorMessage = "The field {0} must contain between the {1} and {2} characters")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(ErrorMessage = "The field {0} is required")]
        [StringLength(25, MinimumLength = 5, ErrorMessage = "The field {0} must contain between the {1} and {2} characters")]
        [Compare("Password", ErrorMessage = "The fields {0} and {1} don't match")]
        [DisplayName("Repeat Password")]
        [DataType(DataType.Password)]
        public string RepeatPassword { get; set; }

        [CheckboxChecked(ErrorMessage = "You have to agree with out terms to continue")]
        [DisplayName("Accept Terms")]
        public bool AcceptTerms { get; set; }
    }
}
