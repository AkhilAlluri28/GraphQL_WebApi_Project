using GraphiQl;
using GraphQL;
using GraphQL.Types;
using GraphQL_Project.Data;
using GraphQL_Project.Interfaces;
using GraphQL_Project.Queries;
using GraphQL_Project.Repositories;
using GraphQL_Project.Schema;
using GraphQL_Project.Types;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add DbContext
builder.Services.AddDbContext<AppDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();
builder.Services.AddScoped<IMenuRepository, MenuRepository>();
builder.Services.AddScoped<IReservationRepository, ReservationRepository>();

builder.Services.AddScoped<CategoryType>();
builder.Services.AddScoped<MenuType>();
builder.Services.AddScoped<ReservationType>();

builder.Services.AddScoped<CategoryQuery>();
builder.Services.AddScoped<MenuQuery>();
builder.Services.AddScoped<ReservationQuery>();
builder.Services.AddScoped<RootQuery>();

builder.Services.AddScoped<ISchema, RootSchema>();
builder.Services.AddGraphQL(b=> b.AddAutoSchema<ISchema>().AddSystemTextJson());

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseGraphiQl("/graphql");
app.UseGraphQL<ISchema>();

app.UseAuthorization();

app.MapControllers();

app.Run();
