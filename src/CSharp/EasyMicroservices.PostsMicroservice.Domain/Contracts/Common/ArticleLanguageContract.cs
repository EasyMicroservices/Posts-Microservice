using EasyMicroservices.ContentsMicroservice.Clients.Attributes;
using System.Collections.Generic;

namespace EasyMicroservices.PostsMicroservice.Contracts.Common
{
    public class ArticleLanguageContract : ArticleBaseContract
    {
        public long Id { get; set; }

        [ContentLanguage(nameof(ArticleContract.Title))]
        public List<LanguageDataContract> Titles { get; set; }

        [ContentLanguage(nameof(ArticleContract.Summary))]
        public List<LanguageDataContract> Summaries { get; set; }

        [ContentLanguage(nameof(ArticleContract.Body))]
        public List<LanguageDataContract> Bodies { get; set; }

        [ContentLanguage(nameof(ArticleContract.Description))]
        public List<LanguageDataContract> Descriptions { get; set; }
    }
}