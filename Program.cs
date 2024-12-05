
using backend.Business;
using backend.Business.Interface;

namespace backend
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            builder.Services.AddScoped<IProductBusiness, ProductBuisness>();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.AddCors(options =>
            {
                options.AddPolicy("GeneralCorsPolicy", policy =>
                {
                    // Allow requests from any origin (if you need a flexible backend for multiple clients)
                    policy.AllowAnyOrigin()
                          .AllowAnyHeader()   // Allow all headers (e.g., Authorization, Content-Type)
                          .AllowAnyMethod();  // Allow all HTTP methods (GET, POST, PUT, DELETE, etc.)
                });
            });

            var app = builder.Build();
            app.UseCors("GeneralCorsPolicy");

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
