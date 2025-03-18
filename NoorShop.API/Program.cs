using Microsoft.EntityFrameworkCore;
using NoorShop.API.Database;
using Scalar.AspNetCore;

namespace NoorShop.API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.AddDbContext<applecationDatabase>(options =>
             options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {

                app.UseSwagger(options =>
                {
                    options.RouteTemplate = "/openapi/{documentName}.json";
                });

                app.UseSwaggerUI(options =>
                {
                    options.SwaggerEndpoint("/openapi/v1.json", "API V1");
                });

                app.MapScalarApiReference();

            }
            var contant = new applecationDatabase();
            try
            {
                contant.Database.CanConnect();
                Console.WriteLine("Done");

            }
            catch (Exception ex)
            {
                Console.WriteLine("errror with data base conneaction");
            }
            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
