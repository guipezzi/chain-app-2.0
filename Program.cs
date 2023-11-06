var builder = WebApplication.CreateBuilder(args);

// Invoke ConfigureServices of AppStartup
var startup = new Startup(builder.Configuration);
startup.ConfigureServices(builder.Services);

var app = builder.Build();

// Invoke Configure of AppStartup
startup.Configure(app, app.Environment);

app.Run();
