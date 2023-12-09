using EasyMicroservices.Cores.Database.Schemas;

namespace EasyMicroservices.PostsMicroservice.Database.Entities;

public class ArticleCategoryEntity : FullAbilitySchema
{
    public long ArticleId { get; set; }
    public long CategoryId { get; set; }

    public ArticleEntity Article { get; set; }
    public CategoryEntity Category { get; set; }
}
