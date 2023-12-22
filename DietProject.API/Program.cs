using System;
using DietProject.BusinnesLayer.Abstracts;
using DietProject.BusinnesLayer.Concretes;
using DietProject.DataAccessLayer.Abstracts;
using DietProject.DataAccessLayer.Concretes;
using DietProject.DataAccessLayer.Context;
using DietProject.EntityLayer.Entities;
using Microsoft.EntityFrameworkCore;


var builder = WebApplication.CreateBuilder(args);
// Add services to the container.
AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);

builder.Services.AddControllers();
builder.Services.AddCors(opt => opt.AddDefaultPolicy(policy =>
    policy.AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin()
));
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<DietDbContext>(opt =>

    opt.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection"))
);
builder.Services.AddIdentity<AppUser, AppRole>().AddEntityFrameworkStores<DietDbContext>();
builder.Services.AddScoped<IFoodService, FoodManager>();
builder.Services.AddScoped<IFoodDal, EfFoodDal>();
builder.Services.AddScoped<IMealService, MealManager>();
builder.Services.AddScoped<IMealDal, EfMealDal>();
builder.Services.AddScoped<IUserInformationService, UserInformationManager>();
builder.Services.AddScoped<IUserInformationDal, EfUserInformationDal>();
builder.Services.AddScoped<IAuthDal, EfAuthDal>();
builder.Services.AddScoped<IAuthService, AuthManager>();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseHttpsRedirection();
app.UseCors();

app.UseAuthorization();

app.MapControllers();

app.Run();

