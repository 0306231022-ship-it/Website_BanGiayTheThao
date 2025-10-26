using WebApplication4.Abstraction;
using WebApplication4.Repository;
var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();
builder.Services.AddScoped<ISanPham, DuLieuGia_SanPham>();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}
//app.UseMiddleware<WebApplication4.Middleware.GhiLog>();
app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Website}/{action=SanPhamNoiBat}/{id?}");

app.Run();

