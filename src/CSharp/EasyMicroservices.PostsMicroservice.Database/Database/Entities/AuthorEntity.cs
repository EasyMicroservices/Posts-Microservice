using EasyMicroservices.Cores.Database.Schemas;
using System.Collections.Generic;

namespace EasyMicroservices.PostsMicroservice.Database.Entities;
public class AuthorEntity : FullAbilityIdSchema<long>
{
    public ICollection<ArticleAuthorEntity> ArticleAuthors { get; set; }
}
