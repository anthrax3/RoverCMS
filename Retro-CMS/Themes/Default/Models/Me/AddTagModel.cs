using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Default.Models.Me
{
    public class AddTagModel
    {
        [Required(ErrorMessage = "This field is required")]
        [StringLength(15, MinimumLength = 3, ErrorMessage = "This field requires between the {1} and {2} characters")]
        public string Tag { get; set; }
    }
}
