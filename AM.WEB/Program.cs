var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
//instance tsir lena f el exam nal9awhom hadhrine 
//3ibara na3mel new ama lezem nrodha el .net howa eli lehi beha
//nzid ken mta3 les services .....<Interface ,classe>=IServceFlight sf = new ServiceFlight();
//ba3ed tzidha f el constructeur par defaut eli f el classe ..
var app = builder.Build();

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
