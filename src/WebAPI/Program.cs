using WebAPI.Services.Abstract;
using WebAPI.Services.Concrete;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddSingleton<ISingletonLifetimeService, SingletonLifetimeService>();
builder.Services.AddTransient<ITransientLifetimeService, TransientLifetimeService>();
builder.Services.AddScoped<IScopedLifetimeService, ScopedLifetimeService>();
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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
