using Microsoft.EntityFrameworkCore;
using final_project_CIDM_3312.Models;

var builder = WebApplication.CreateBuilder(args);

	// Add services to the container.
	builder.Services.AddRazorPages();
	// Bring in database context with dependency injection.
	builder.Services.AddDbContext<AppDbContext>(options =>
	    options.UseSqlite(builder.Configuration.GetConnectionString("GameConnection")));
	
	var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseRouting();

app.UseAuthorization();

app.MapStaticAssets();
app.MapRazorPages()
   .WithStaticAssets();

app.Run();
