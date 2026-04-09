var builder = WebApplication.CreateBuilder(args);

#region Add Service To the container

#endregion

var app = builder.Build();
#region Request pipeline
app.MapGet("/", () => "API is working!");
#endregion
app.Run();
