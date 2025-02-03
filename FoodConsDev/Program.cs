using Dapper;
using FoodConsluting.Repositories;
using FoodConsluting.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();     

var app = builder.Build();

// Newest self changes 30.1.2025
SimpleCRUD.SetDialect(SimpleCRUD.Dialect.MySQL);

// For building reposs
// Not sure if this will work...
builder.Services.AddSingleton<IStandardRepository, StandardRepository>();



//builder.Services.AddAutoMapper(typeof(MapperService));

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
