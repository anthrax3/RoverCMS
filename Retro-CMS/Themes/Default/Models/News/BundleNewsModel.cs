using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Default.Models.News
{
    public class BundleNewsModel
    {
        public ArticleModel Article { get; set; }
        public WriteCommentModel WriteComment { get; set; }

        public IEnumerable<ArticleModel> Articles { get; set; }
        public IEnumerable<CommentModel> Comments { get; set; }
    }
}
