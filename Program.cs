using ApiSalao.EndPoints;
using ApiSalao.Models;


var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<d37g66beu35psqContext>();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseAuthorization();

app.mapLoginEndPoints();
app.mapUserEndPoints();

app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();
app.Run();
