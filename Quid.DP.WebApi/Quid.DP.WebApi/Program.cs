using Quid.DP.Business.Contracts;
using Quid.DP.Business.Managers;
using Quid.DP.Data.Contracts;
using Quid.DP.ProviderOne.Services;
using Quid.DP.ProviderTwo.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Httpclient via DI
builder.Services.AddHttpClient();

//HttpContextAccessor
builder.Services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

//Services DI
builder.Services.AddSingleton<IOneManager, OneManager>();
builder.Services.AddSingleton<ITwoManager, TwoManager>();
builder.Services.AddSingleton<IOneService, OneService>();
builder.Services.AddSingleton<ITwoService, TwoService>();

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