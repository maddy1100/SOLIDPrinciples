using BestPractices.Services.ISP;
using BestPractices.Services.ISP.Interfaces;
using BestPractices.Services.SRP;
using BestPractices.Services.SRP.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddTransient<IEmailService, EmailService>();
builder.Services.AddTransient<IPaymentOnline, OrderWithOnlinePayment>();
builder.Services.AddTransient<IPaymentOffline, OrderWithCashPayment>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
