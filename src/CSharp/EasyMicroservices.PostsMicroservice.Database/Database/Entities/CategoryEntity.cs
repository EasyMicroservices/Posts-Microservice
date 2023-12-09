using EasyMicroservices.Cores.Database.Schemas;
using System.Collections.Generic;

namespace EasyMicroservices.PostsMicroservice.Database.Entities;

public class CategoryEntity : FullAbilityIdSchema<long>
{
    public long? ParentId { get; set; }
    public CategoryEntity Parent { get; set; }

    public ICollection<CategoryEntity> Children { get; set; }
    public ICollection<ArticleCategoryEntity> ArticleCategories { get; set; }
}
