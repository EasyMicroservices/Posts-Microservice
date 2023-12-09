using EasyMicroservices.Cores.Interfaces;
using EasyMicroservices.PostsMicroservice.Database.Schemas;
using System.Collections.Generic;

namespace EasyMicroservices.PostsMicroservice.Database.Entities
{
    public class ArticleEntity : ArticleSchema, IIdSchema<long>
    {
        public long Id { get; set; }

        public ICollection<ArticleCategoryEntity> ArticleCategories { get; set; }
        public ICollection<ArticleAuthorEntity> ArticleAuthors { get; set; }
    }
}
