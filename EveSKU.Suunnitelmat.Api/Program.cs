var rakentaja = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
rakentaja.Services.AddOpenApi();

var softa = rakentaja.Build();

// Configure the HTTP request pipeline.
if (softa.Environment.IsDevelopment())
{
    softa.MapOpenApi();
}

softa.UseHttpsRedirection();





softa.Run();


