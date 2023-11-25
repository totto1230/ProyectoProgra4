

using Progra4BD.BLL;
using Progra4BD.Dapper;
using Progra4BD.IBLL;
using Progra4BD.IDapper;
using Progra4BD.IRepositorios;
using Progra4BD.Repositorios;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddSingleton<IDapperContext, DapperContext>();
//instancias de repositorios
builder.Services.AddSingleton<IClientesRepositorio, ClientesRepositorio>();



//instancias de BLL's
builder.Services.AddSingleton<ICLienteBLL, ClienteBLL>();



var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
