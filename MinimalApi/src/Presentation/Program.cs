using MinimalApi.Presentation.Endpoints.Authors;
using MinimalApi.Presentation.Endpoints.Movies;
using MinimalApi.Presentation.Endpoints.Reviews;
using MinimalApi.Presentation.Endpoints.Version;
using MinimalApi.Presentation.Extensions;
using Serilog;

var builder = WebApplication
                .CreateBuilder(args)
                .ConfigureBuilder();

_ = builder.Services.AddControllers();

// var applicationBuilder = builder.Services
//     .BuildServiceProvider();

var app = builder
            .Build()
            .ConfigureApplication();

// _ = app.MapVersionEndpoints();
// _ = app.MapAuthorEndpoints();
// _ = app.MapMovieEndpoints();
// _ = app.MapReviewEndpoints();

try
{
    Log.Information("Starting host");
    app.Run();
    return 0;
}
catch (Exception ex)
{
    Log.Fatal(ex, "Host terminated unexpectedly");
    return 1;
}
finally
{
    Log.CloseAndFlush();
}
