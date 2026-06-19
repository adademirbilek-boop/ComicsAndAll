using ComicsAndAllProject.Core.RepositoryInterfaces;
using ComicsAndAllProject.Plugins.EFCore.Data;
using ComicsAndAllProject.Plugins.EFCore.Repositories;
using ComicsAndAllProject.UseCases.CharacterInterfaces;
using ComicsAndAllProject.UseCases.CharacterUsecases;
using ComicsAndAllProject.UseCases.Interfaces;
using ComicsAndAllProject.UseCases.IssueInterfaces;
using ComicsAndAllProject.UseCases.IssueUsecases;
using ComicsAndAllProject.UseCases.PublisherInterfaces;
using ComicsAndAllProject.UseCases.PublisherUsecases;
using ComicsAndAllProject.UseCases.SeriesInterfaces;
using ComicsAndAllProject.UseCases.SeriesUsecases;
using Microsoft.EntityFrameworkCore;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddScoped<ISeriesRepository, SeriesRepository>();
builder.Services.AddScoped<IPublishersRepository, PublishersRepository>();
builder.Services.AddScoped<IViewSeriesUsecase, ViewSeriesUsecase>();
builder.Services.AddScoped<ICharactersRepository,CharactersRepository>();
builder.Services.AddScoped<IGetCharacterByIdUsecase, GetCharacterByIdUsecase>();
builder.Services.AddScoped<IIssuesRepository, IssuesRepository>();
builder.Services.AddScoped<ISearchSeriesUsecase, SearchSeriesUsecase>();
builder.Services.AddScoped<IGetAllPublishersUsecase, GetAllPublishersUsecase>();
builder.Services.AddScoped<IGetPublisherUsecase, GetPublisherUsecase>();
builder.Services.AddScoped<ISearchPublishersUsecase, SearchPublisherUsecase>();
builder.Services.AddScoped<IGetSeriesByPublisherIdUsecase, GetSeriesByPublisherIdUsecase>();


builder.Services.AddScoped<IGetIssueUsecase , GetIssueUsecase>();
builder.Services.AddScoped<IGetAllIssuesUsecase, GetAllIssuesUsecase>();
builder.Services.AddScoped<IGetSeriesByIdUsecase, GetSeriesByIdUsecase>();
builder.Services.AddScoped<IGetAllCharactersUsecase, GetAllCharactersUsecase>();

builder.Services.AddDbContext<ComicsAndAllDbContext>(options =>
    options.UseSqlServer(
        builder.Configuration.GetConnectionString("DefaultConnection")));




var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var db = scope.ServiceProvider
        .GetRequiredService<ComicsAndAllDbContext>();

    SeedData.Seed(db);
}


// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
