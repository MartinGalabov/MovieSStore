using FluentValidation.AspNetCore;
using FluentValidation;
using Mapster;
using MovieSStore.BizLayer;
using MovieSStore.DataLayer;
using Serilog;
using Serilog.Sinks.SystemConsole.Themes;
using MovieSStore.Controllers;

namespace MovieSStore
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            var logger = new LoggerConfiguration()
                .Enrich.FromLogContext()
                .WriteTo.Console(theme: AnsiConsoleTheme.Code)
                .CreateLogger();

            // Add services to the container.

            builder.Services
                .AddDataDependencies()
                .AddBusinessDependencies();

            builder.Services.AddMapster();

            builder.Services.AddValidatorsFromAssemblyContaining<TestRequest>();
            builder.Services.AddFluentValidationAutoValidation();

            builder.Services.AddControllers();
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.MapControllers();

            app.Run();
        }
    }
}