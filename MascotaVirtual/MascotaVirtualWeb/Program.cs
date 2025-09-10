var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.UseDefaultFiles(); // busca index.html
app.UseStaticFiles();  // sirve wwwroot/*

app.Run();