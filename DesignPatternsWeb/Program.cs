using BusinessLibrary.Repositories;
using BusinessLibrary.Services.Singleton;
using DesignPatternsWeb.DB;
using DesignPatternsWeb.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Logging.AddConsole();
builder.Services.AddDbContext<InMemeoryDBContext>();

builder.Services.AddSingleton<ISayHello, MemoryHungryService>();
builder.Services.AddTransient<CustomersUnitOfWork>();
builder.Services.AddTransient<IOrdersRepository, OrdersRepository>();

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
