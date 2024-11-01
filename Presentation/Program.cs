using FastEndpoints;
using Presentation.Extentions;
using Application.Extentions;
using Infrastructure.Extentions;
using FastEndpoints.Swagger;

var builder = WebApplication.CreateBuilder(args);

builder.Services.ConfigureApplication();
builder.Services.ConfigureInfrastructure(builder.Configuration);

builder.Services.AddFastEndpointsBehavior();
builder.Services.AddCorsBehavior();

builder.Services.AddAuthentication();
builder.Services.AddAuthorization();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// uncomment for api
//if (app.Environment.IsDevelopment())
//{
//    app.UseSwagger();
//    app.UseSwaggerUI();
//}

app.UseHttpsRedirection();
app.UseAuthentication();
app.UseAuthorization();
app.UseCors();

app.UseFastEndpoints(e =>
{
    e.Endpoints.RoutePrefix = "api";
}).UseSwaggerGen();

app.Run();