using EasyMicroservices.Cores.Database.Schemas;

namespace EasyMicroservices.PostsMicroservice.Database.Entities;
public class ArticleAuthorEntity : FullAbilitySchema
{
    public long ArticleId { get; set; }
    public long AuthorId { get; set; }

    public ArticleEntity Article { get; set; }
    public AuthorEntity Author { get; set; }
}
