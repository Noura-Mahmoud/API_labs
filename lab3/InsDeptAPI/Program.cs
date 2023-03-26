
using InsDeptAPI.Models;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Cors.Infrastructure;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.Text;

namespace InsDeptAPI
{
    public class Program
    {

        public static void Main(string[] args)
        {
            var configuration = new ConfigurationBuilder()
    .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true).Build();
            var builder = WebApplication.CreateBuilder(args);
            // Add services to the container.


            builder.Services.AddIdentity<AppIdentityUser, IdentityRole>()
                .AddEntityFrameworkStores<InsDeptDbContextAPI>();

            //Authorization with JWT token in Authentication check
            builder.Services.AddAuthentication(options =>
            {
                options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
            }).AddJwtBearer(options=>
            {
                options.SaveToken = true;
                options.RequireHttpsMetadata = false;
                options.TokenValidationParameters = new TokenValidationParameters()
                {
                    ValidateIssuer = true,
                    ValidIssuer = configuration["JWT:ValidIssuer"],
                    ValidateAudience =true,
                    ValidAudience = configuration["JWT:ValidAudience"],
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["JWT:Secret"]))
            };
            });
            //------

            builder.Services.AddControllers();
            // Add connectionString
            var connectionString = builder.Configuration.GetConnectionString("InsDeptConn") ?? throw new InvalidOperationException("Connection string 'InsDeptConn' not found.");
            // add the service to the builder
            builder.Services.AddDbContext<InsDeptDbContextAPI>(op => op.UseSqlServer(connectionString));
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            //CORS service
            builder.Services.AddCors(CorsOptions =>
                {
                    CorsOptions.AddPolicy("myPolicy", CorsPolicyBuilder =>
                    {
                        CorsPolicyBuilder.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod();
                    });
                }
            );


            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }


            app.UseCors("myPolicy");
            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseAuthorization();
            app.UseAuthentication(); // check JWT token

            app.MapControllers();

            app.Run();
        }
    }
}