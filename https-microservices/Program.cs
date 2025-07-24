var builder = WebApplication.CreateBuilder(args);
builder.WebHost.ConfigureKestrel(options =>
{
    options.ListenAnyIP(443, listenOptions =>
    {
        listenOptions.UseHttps("certs/localhost.pfx", "password");
    });
});
builder.Services.AddControllers();
var app = builder.Build();
app.MapControllers();
app.Run();
