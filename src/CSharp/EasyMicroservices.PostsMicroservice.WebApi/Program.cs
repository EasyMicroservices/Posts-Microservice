using EasyMicroservices.Cores.AspEntityFrameworkCoreApi;
using EasyMicroservices.Cores.Relational.EntityFrameworkCore.Intrerfaces;
using EasyMicroservices.PostsMicroservice.Database.Contexts;

namespace EasyMicroservices.PostsMicroservice.WebApi
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var app = CreateBuilder(args);
            var build = await app.Build<PostContext>();
            build.MapControllers();
            build.Run();
        }

        static WebApplicationBuilder CreateBuilder(string[] args)
        {
            var app = StartUpExtensions.Create<PostContext>(args);
            app.Services.Builder<PostContext>().UseDefaultSwaggerOptions();
            app.Services.AddTransient<PostContext>();
            app.Services.AddTransient<IEntityFrameworkCoreDatabaseBuilder, DatabaseBuilder>();
            StartUpExtensions.AddAuthentication("RootAddresses:Authentication");
            StartUpExtensions.AddWhiteLabel("Posts", "RootAddresses:WhiteLabel");
            return app;
        }
    }
}