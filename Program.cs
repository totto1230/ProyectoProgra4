using ProyectoPrograCuatro.BLL;
using ProyectoPrograCuatro.Dapper;
using ProyectoPrograCuatro.IBLL;
using ProyectoPrograCuatro.IDapper;
using ProyectoPrograCuatro.IRepositorios;
using ProyectoPrograCuatro.Repositorios;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddSession();

builder.Services.AddSingleton<IDapperContext, DapperContext>();

//instancias de repositorios
builder.Services.AddSingleton<IClientesRepositorio, ClientesRepositorio>();

builder.Services.AddSingleton<ICamionesRepositorio, CamionesRepositorio>();

builder.Services.AddSingleton<IChoferesRepositorio, ChoferesRepositorio>();

builder.Services.AddSingleton<IUsuariosRepositorio, UsuariosRepositorio>();

//instancias de BLL's
builder.Services.AddSingleton<ICLienteBLL, ClienteBLL>();

builder.Services.AddSingleton<ICamionesBLL, CamionesBLL>();

builder.Services.AddSingleton<IChoferesBLL, ChoferBLL>();

builder.Services.AddSingleton<IUsuariosBLL, UsuariosBLL>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.UseSession();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
