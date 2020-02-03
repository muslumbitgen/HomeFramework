using HomeFramework.Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace HomeFramework.Entities.Concrete
{
    public class Article : IEntity
    {
        public int ArticleId { get; set; }
        public int CategoryId { get; set; }
        public string Title { get; set; }
        public string ContentSummary { get; set; }
        public string ContentMain { get; set; }
        public string Picture { get; set; }
        public DateTime PublishDate { get; set; }
        public int ViewCount { get; set; }

    }
}
