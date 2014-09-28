using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Default.Models.News
{
    public class WriteCommentModel
    {
        [DisplayName("Write a comment")]
        public string Comment { get; set; }
    }
}
