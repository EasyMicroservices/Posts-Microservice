using EasyMicroservices.Cores.Relational.EntityFrameworkCore;
using EasyMicroservices.Cores.Relational.EntityFrameworkCore.Intrerfaces;
using EasyMicroservices.PostsMicroservice.Database.Entities;
using Microsoft.EntityFrameworkCore;

namespace EasyMicroservices.PostsMicroservice.Database.Contexts
{
    public class PostContext : RelationalCoreContext
    {
        public PostContext(IEntityFrameworkCoreDatabaseBuilder builder) : base(builder)
        {
        }

        public DbSet<ArticleEntity> Articles { get; set; }
        public DbSet<ArticleCategoryEntity> ArticleCategories { get; set; }
        public DbSet<CategoryEntity> Categories { get; set; }
        public DbSet<AuthorEntity> Authors { get; set; }
        public DbSet<ArticleAuthorEntity> ArticleAuthors { get; set; }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.AutoModelCreating(modelBuilder);

            modelBuilder.Entity<ArticleCategoryEntity>(entity =>
            {
                entity.HasKey(x => new { x.ArticleId, x.CategoryId });
            });

            modelBuilder.Entity<ArticleAuthorEntity>(entity =>
            {
                entity.HasKey(x => new { x.ArticleId, x.AuthorId });
            });
        }
    }
}