using EasyMicroservices.ContentsMicroservice.Clients.Attributes;

namespace EasyMicroservices.PostsMicroservice.Contracts.Common
{
    public class ArticleContract : ArticleBaseContract
    {
        public long Id { get; set; }

        [ContentLanguage]
        public string Title { get; set; }
        [ContentLanguage]
        public string Summary { get; set; }
        [ContentLanguage]
        public string Body { get; set; }

        [ContentLanguage]
        public string Description { get; set; }
    }
}
