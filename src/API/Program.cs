using API;
using API.Delivery;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IDeliveryService, DeliveryService>();
builder.Services.AddSingleton<IDeliveryProvider, UPS>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.MapGet("/{price}", (IDeliveryService service, int price) => service.Calculate(price));

app.Run();