global using ASS_WMS;
global using ASS_WMS.Models;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
builder.Services.AddSqlServer<DB>($@"
    Data Source=(LocalDB)\MSSQLLocalDB;
    AttachDbFilename={builder.Environment.ContentRootPath}\DB.mdf;
");
//builder.Services.AddScoped<Helper>();
builder.Services.AddAuthentication().AddCookie();
builder.Services.AddHttpContextAccessor();

var app = builder.Build();
app.UseHttpsRedirection();
app.UseStaticFiles();

// Culture = en-MY, ms-MY, zh-CN, ja-JP, ko-KR, etc.
// TODO
app.UseRequestLocalization("ja-JP");

app.MapDefaultControllerRoute();
app.Run();
