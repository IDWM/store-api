using Microsoft.EntityFrameworkCore;
using store_api.Src.Data;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<DataContext>(options => options.UseSqlite("Data Source=store.db"));

var app = builder.Build();

app.Run();
