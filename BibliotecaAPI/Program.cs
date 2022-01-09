using BibliotecaAPI;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

//Estas parte se comentarea y se pasa a la clase Startup.cs (Lineas 7 - 10)

//builder.Services.AddControllers();
//// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
//builder.Services.AddEndpointsApiExplorer();
//builder.Services.AddSwaggerGen();

//Se agregan las lineas 16 - 18 para leer los ajustes de Startup.cs

var startup = new Startup(builder.Configuration);

startup.ConfigureServices(builder.Services);

var app = builder.Build();

// Configure the HTTP request pipeline.

//Estas parte se comentarea y se pasa a la clase Startup.cs (Lineas 26 - 36)

//if (app.Environment.IsDevelopment())
//{
//    app.UseSwagger();
//    app.UseSwaggerUI();
//}

//app.UseHttpsRedirection();

//app.UseAuthorization();

//app.MapControllers();

//Se agregan las lineas 40 para leer los ajustes de Startup.cs

startup.Configure(app, app.Environment);

app.Run();
