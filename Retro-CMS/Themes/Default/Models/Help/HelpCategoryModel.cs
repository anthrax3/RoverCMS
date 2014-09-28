using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Default.Models.Help
{
    public class HelpCategoryModel
    {
        public IEnumerable<HelpArticleModel> HelpArticles { get; set; }

        public HelpCategoryModel()
        {
            HelpArticles = new Collection<HelpArticleModel>();
        }
    }
}
