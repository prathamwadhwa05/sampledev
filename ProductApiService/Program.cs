using ProductApiService.Business_Layer;
using ProductApiService.Data_Access_Layer;
using ProductApiService.Shared_Layer.Interfaces;
using Steeltoe.Discovery.Client;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
//builder.Services.AddDiscoveryClient();
//builder.Services.AddHealthChecks();
//builder.Services.AddMassTransit(config =>
//{
//    config.AddConsumer<OrderConsumer>();
//    config.UsingRabbitMq((ctx, cfg) => {
//        cfg.Host("amqp://guest:guest@localhost:5672");
//        cfg.ReceiveEndpoint("order-queue", c =>
//        {
//            c.ConfigureConsumer<OrderConsumer>(ctx);
//        });


//    });
//});
//builder.Services.AddMassTransitHostedService();
builder.Services.AddScoped<IProductRepository, ProductRepository>();
builder.Services.AddScoped<IProductRepositoryBL, ProductRepositoryBL>();



var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();
//app.UseHealthChecks("/info");


app.MapControllers();

app.Run();
