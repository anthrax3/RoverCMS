using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Default.Models.Auction
{
    public class AuctionAddBidModel
    {
        // Maximum length of an int32
        [Required(ErrorMessage = "This field is required")]
        [Range(1, 2147483647, ErrorMessage = "The minimum is: {1} and the maximum bid is: {2}")]
        public int Credits { get; set; }
    }
}
