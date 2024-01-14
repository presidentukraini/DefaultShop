var builder = WebApplication.CreateBuilder(args);

// Додаємо з'єднання з базою даних PostgreSQL


builder.Services.AddControllersWithViews();

var app = builder.Build();

// Решта коду залишається незмінним

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
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

