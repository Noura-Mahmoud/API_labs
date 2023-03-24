
using InsDeptAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace InsDeptAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Add connectionString
            var connectionString = builder.Configuration.GetConnectionString("InsDeptConn") ?? throw new InvalidOperationException("Connection string 'InsDeptConn' not found.");
            // add the service to the builder
            builder.Services.AddDbContext<InsDeptDbContextAPI>(op => op.UseSqlServer(connectionString));
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
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