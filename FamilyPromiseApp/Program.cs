using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using FamilyPromiseApp.Data;
using Microsoft.AspNetCore.Identity;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
//builder.Services.AddDbContext<FamilyPContext>(options =>
    //options.UseSqlite(builder.Configuration.GetConnectionString("FamilyContext") ?? throw new InvalidOperationException("Connection string 'FamilyContext' not found.")));

builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true).AddEntityFrameworkStores<FamilyPContext>();
builder.Services.AddDbContext<FamilyPContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("FamilyContext") ?? throw new InvalidOperationException("Connection string 'FamilyPContext' not found.")));
builder.Services.AddDatabaseDeveloperPageExceptionFilter();

//builder.Services.AddDbContext<FamilyPContext>(options =>
    //options.UseSqlServer(builder.Configuration.GetConnectionString("AZURE_SQL_CONNECTIONSTRING")));
builder.Services.AddDistributedMemoryCache();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}
else
{
    app.UseDeveloperExceptionPage();
    app.UseMigrationsEndPoint();
}
using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;

    var context = services.GetRequiredService<FamilyPContext>();
    DbInitializer.Initialize(context);
}


app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();  // Use MapControllers instead of MapControllerRoute

app.MapRazorPages();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}")
    .RequireAuthorization();  // Require authorization for the default route

app.Run();