using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using projectef;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddSqlServer<tareaContext>(builder.Configuration.GetConnectionString("cnTareas"));
 var app = builder.Build(); //APP CORRIENDO Y ESCUCHANDO PETICIONES

app.MapGet("/dbConexion", async([FromServices] tareaContext DbContext) => 
{
    try
    {
        DbContext.Database.EnsureCreated();
        return Results.Ok("base de datos en memoria: "+DbContext.Database.IsInMemory());//true o false segun ka coneecion
    }
    catch (Exception e)

    {
        return Results.Ok("error al verificar la base de datos en memoria: "+ e.Message);
        
        throw;
    }

});

app.Run();


