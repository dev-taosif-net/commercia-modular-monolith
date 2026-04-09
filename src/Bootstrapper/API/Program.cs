var builder = WebApplication.CreateBuilder(args);

#region Add Service To the container

builder.Services
    .AddCatalogModule(builder.Configuration)
    .AddBasketModule(builder.Configuration)
    .AddOrderModule(builder.Configuration);

#endregion

var app = builder.Build();

#region Request http pipeline

app.UseCatalogModule()
    .UseBasketModule()
    .UseOrderModule();

app.MapGet("/", () => "API is working!");

#endregion

app.Run();