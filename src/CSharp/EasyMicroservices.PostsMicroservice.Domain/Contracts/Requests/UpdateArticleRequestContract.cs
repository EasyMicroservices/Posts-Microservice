namespace EasyMicroservices.PostsMicroservice.Contracts.Requests
{
    public class UpdateArticleRequestContract : CreateArticleRequestContract
    {
        public long Id { get; set; }
    }
}
