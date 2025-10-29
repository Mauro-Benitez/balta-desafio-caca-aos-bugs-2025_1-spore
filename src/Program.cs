using BugStore.Data;
using Microsoft.EntityFrameworkCore;


var builder = WebApplication.CreateBuilder(args);

var conectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<AppDbContext>(O => O.UseNpgsql(conectionString));
    //AddDbContext<AppDbContext>(options => options.UseNpgsql(conectionString));


var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();
