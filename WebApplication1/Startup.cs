using DataBase.Context;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Core.Services;
using DataBase.Repositories;

namespace WebApplication1
{
    public static class Startup
    {
        public static void ConfigureServices(IServiceCollection services)
        {
            services.AddServices();
            services.AddRepository();
        }

        public static void AddServices(this IServiceCollection services)
        {
            services.AddScoped<IAuthorService,AuthorService>();
            services.AddScoped<IBookService,BookService> ();
        }

        public static void AddRepository(this IServiceCollection services)
        {
            services.AddScoped<IBookRepository,BookRepository>();
            services.AddScoped<IAuthorRepository,AuthorRepository>();
            services.AddDbContext<ProjectDbContext>();
            services.AddScoped<DbContext, ProjectDbContext>();
        }
    }
}
