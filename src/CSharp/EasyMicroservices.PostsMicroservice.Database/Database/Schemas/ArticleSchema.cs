using EasyMicroservices.Cores.Database.Schemas;
using System;

namespace EasyMicroservices.PostsMicroservice.Database.Schemas
{
    public class ArticleSchema : FullAbilitySchema
    {
        public DateTime? PublishedDateTime { get; set; }
    }
}
