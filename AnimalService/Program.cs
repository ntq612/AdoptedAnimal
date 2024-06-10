using AnimalService.Context;
using MassTransit;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Connect to MSSQL with DB Context
builder.Services.AddDbContext<AnimalDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"),
        sqlOptionsBuilder => sqlOptionsBuilder.EnableRetryOnFailure());
});

builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

//Config RabbitMQ
builder.Services.AddMassTransit(x =>
{
    // Add outbox
    //x.AddEntityFrameworkOutbox<AnimalDbContext>(o =>
    //{
    //    o.QueryDelay = TimeSpan.FromSeconds(10);

    //    o.UseSqlServer();
    //    o.UseBusOutbox();
    //});

    x.SetEndpointNameFormatter(new KebabCaseEndpointNameFormatter("animal", false));

    // Setup RabbitMQ Endpoint
    x.UsingRabbitMq((context, cfg) =>
    {

        cfg.Host(builder.Configuration["RabbitMq:Host"], "/", host =>
        {
            host.Username(builder.Configuration.GetValue("RabbitMq:Username", "guest"));
            host.Password(builder.Configuration.GetValue("RabbitMq:Password", "guest"));
        });
        cfg.ConfigureEndpoints(context);
    });
});
// Add services to the container.

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.Run();

internal record WeatherForecast(DateOnly Date, int TemperatureC, string? Summary)
{
    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
}
