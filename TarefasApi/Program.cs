using TarefasApi.Data.Endpoints;
using TarefasApi.Data.Endpoints.Extencions;

var builder = WebApplication.CreateBuilder(args);

builder.AddPersitence();

var app = builder.Build();

app.MapTarefasEndpoints();

app.Run();
