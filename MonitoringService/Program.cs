var builder = WebApplication.CreateBuilder(args);

builder.Services.AddHealthChecksUI(
//settings =>

//{
//    settings.AddHealthCheckEndpoint("ServiceB", "https://localhost:7127/health");
//    settings.AddHealthCheckEndpoint("ServiceA", "https://localhost:7092/health");
//    settings.SetEvaluationTimeInSeconds(30); // time in seconds between check
//    settings.SetApiMaxActiveRequests(3); // api requests concurrency


//}

).AddSqlServerStorage(builder.Configuration.GetConnectionString("SQLServer"));



var app = builder.Build();

app.UseHealthChecksUI( options =>
{
    options.UIPath = "/health-ui";
    options.AddCustomStylesheet("health-checks-ui.css");
    
    
    });

app.Run();
