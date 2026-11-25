using Biblioteca.Application.Interfaces;
using Biblioteca.Application.Services;
using Biblioteca.Infrastructure.Data;
using Biblioteca.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Biblioteca.Presentation
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            var services = new ServiceCollection();

            services.AddDbContext<BibliotecaContext>(options =>
                options.UseSqlite("Data Source=biblioteca.db"));

            services.AddScoped<IAutorRepository, AutorRepository>();
            services.AddScoped<ILivroRepository, LivroRepository>();

            services.AddScoped<AutorService>();
            services.AddScoped<LivroService>();

            services.AddTransient<Form1>();
            services.AddTransient<FormAutor>();
            services.AddTransient<FormConsultaAutores>();

            var serviceProvider = services.BuildServiceProvider();

            using (var scope = serviceProvider.CreateScope())
            {
                var context = scope.ServiceProvider.GetRequiredService<BibliotecaContext>();

                context.Database.EnsureCreated();
            }

            ApplicationConfiguration.Initialize();

            System.Windows.Forms.Application.Run(
                serviceProvider.GetRequiredService<Form1>());
        }
    }
}