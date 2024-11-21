using Microsoft.EntityFrameworkCore;
using SistemaEscolar.Data;
using SistemaEscolar.Repositorios;
using SistemaEscolar.Repositorios.Interfaces;

namespace SistemaEscolar
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

            builder.Services.AddEntityFrameworkSqlServer()
                .AddDbContext<SistemaEscolarDBContext>(
                    options => options.UseSqlServer(builder.Configuration.GetConnectionString("DataBase"))
                );

            builder.Services.AddCors(options =>
            {
                options.AddPolicy("AllowFrontend", policy =>
                {
                    policy.WithOrigins("http://localhost:4200") // URL do Angular
                          .AllowAnyMethod()
                          .AllowAnyHeader();
                });
            });

            builder.Services.AddScoped<IProfessorRepositorio, ProfessorRepositorio>();
            builder.Services.AddScoped<IDisciplinaRepositorio, DisciplinaRepositorio>();
            builder.Services.AddScoped<ITurmaRepositorio, TurmaRepositorio>();
            builder.Services.AddScoped<ISalaRepositorio, SalaRepositorio>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseCors("AllowFrontend");

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
