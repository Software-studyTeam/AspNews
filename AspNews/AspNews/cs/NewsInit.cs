using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using AspNews.Models.cjl;

namespace AspNews.cs
{
    public class NewsInit : DropCreateDatabaseIfModelChanges<News>
    { protected override void Seed(News context)
        { base.Seed(context);
        }
    }
}