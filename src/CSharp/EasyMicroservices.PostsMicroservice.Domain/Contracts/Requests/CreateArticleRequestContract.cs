using EasyMicroservices.ContentsMicroservice.Clients.Attributes;
using EasyMicroservices.Cores.Interfaces;
using EasyMicroservices.PostsMicroservice.Contracts.Common;
using System.Collections.Generic;

namespace EasyMicroservices.PostsMicroservice.Contracts.Requests
{
    public class CreateArticleRequestContract : IUniqueIdentitySchema
    {
        [ContentLanguage(nameof(ArticleContract.Title))]
        public List<LanguageDataContract> Titles { get; set; }

        [ContentLanguage(nameof(ArticleContract.Summary))]
        public List<LanguageDataContract> Summaries { get; set; }

        [ContentLanguage(nameof(ArticleContract.Body))]
        public List<LanguageDataContract> Bodies { get; set; }

        [ContentLanguage(nameof(ArticleContract.Description))]
        public List<LanguageDataContract> Descriptions { get; set; }

        public string UniqueIdentity { get; set; }
    }
}
