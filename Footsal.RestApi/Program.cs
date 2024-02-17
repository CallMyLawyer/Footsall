using Footsal.Persistence;
using Footsal.Persistence.Players;
using Footsal.Persistence.Teams;
using Footsal.Services.Players;
using Footsal.Services.Players.Contracts;
using Footsal.Services.Players.Contracts.Dtos;
using Footsal.Services.Teams;
using Footsal.Services.Teams.Contracts;
using Footsal.TaavContracts;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<EFDataContext>();
builder.Services.AddScoped<IUnitOfWork, EFUnitOfWork>();
builder.Services.AddScoped<ITeamService, TeamAppService>();
builder.Services.AddScoped<ITeamRepository, EFRepositoryTeam>();
builder.Services.AddScoped<IPlayerService, PlayerAppService>();
builder.Services.AddScoped<IPlayerRepository, EFRepositoryPlayer>();

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