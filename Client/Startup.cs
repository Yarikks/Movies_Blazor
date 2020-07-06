using Blazor.FileReader;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.Builder;
using Microsoft.Extensions.DependencyInjection;
using Movies_Blazor.Client.Auth;
using Movies_Blazor.Client.Helpers;
using Movies_Blazor.Client.Repository;

namespace Movies_Blazor.Client
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddTransient<IRepository, RepositoryInMemory>();
            services.AddScoped<IHttpService, HttpService>();
            services.AddScoped<IGenreRepository, GenreRepository>();
            services.AddScoped<IPersonRepository, PersonRepository>();
            services.AddScoped<IMoviesRepository, MoviesRepository>();
            services.AddScoped<IAccountsRepository, AccountsRepository>();
            services.AddScoped<IRatingRepository, RatingRepository>();
            services.AddFileReaderService(options => options.InitializeOnFirstCall = true);
            services.AddAuthorizationCore();

            services.AddScoped<JWTAuthenticationStateProvider>();

            services.AddScoped<AuthenticationStateProvider, JWTAuthenticationStateProvider>(
                provider => provider.GetRequiredService<JWTAuthenticationStateProvider>());

            services.AddScoped<ILoginService, JWTAuthenticationStateProvider>(
                provider => provider.GetRequiredService<JWTAuthenticationStateProvider>());
        }

        public void Configure(IComponentsApplicationBuilder app)
        {
            app.AddComponent<App>("app");
        }
    }
}
