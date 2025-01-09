using FluentValidation.AspNetCore;
using FluentValidation;
using Mapster;
using MovieSStore.BizLayer;
using MovieSStore.DataLayer;
using Serilog;
using Serilog.Sinks.SystemConsole.Themes;
using MovieSStore.Controllers;
using MovieStoreB.HealthChecks;
using MovieSStore.ServiceExtensions;

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
                .AddConfigurations(builder.Configuration)
                .AddDataDependencies()
                .AddBusinessDependencies();


            builder.Services.AddMapster();

            builder.Services.AddValidatorsFromAssemblyContaining<TestRequest>();
            builder.Services.AddFluentValidationAutoValidation();

            builder.Services.AddControllers();
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            //builder.Services.AddHealthChecks();

            builder.Services.AddHealthChecks().AddCheck<SampleHealthCheck>("Sample");

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.MapHealthChecks("/healthz");

            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.MapControllers();

            app.Run();
        }
    }
}