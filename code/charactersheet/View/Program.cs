using System.Net;
using Domain.Repositories.Implementations;
using Domain.Repositories.Interfaces;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.Server;
using Microsoft.EntityFrameworkCore;
using Model.Configurations;
using Model.Entities;
using Model.Identity;
using Radzen;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();

builder.Services.AddDbContext<CharacterSheetDbContext>(
    options => {
        options.EnableSensitiveDataLogging();
        options.UseLazyLoadingProxies().UseMySql(
            builder.Configuration.GetConnectionString("DefaultConnection"),
            new MySqlServerVersion(new Version(8, 0, 27))
        );
    },
    ServiceLifetime.Transient
);

builder.Services.AddScoped<ICharacterRepository, CharacterRepository>();
builder.Services.AddScoped<IRaceRepository, RaceRepository>();
builder.Services.AddScoped<IClassRepository, ClassRepository>();
builder.Services.AddScoped<IRepository<Background>, BackgroundRepository>();
builder.Services.AddScoped<IApplicationUserRepository, ApplicationUserRepository>();
builder.Services.AddScoped<IAbilityNameRepository, AbilityNameRepository>();
builder.Services.AddScoped<ISpellRepository, SpellRepository>();
builder.Services.AddScoped<IRepository<ExperienceProficencyBonu>, ExperienceProficiencyBonusRepository>();
builder.Services.AddScoped<IRepository<EWeaponType>, WeaponTypeRepository>();
builder.Services.AddScoped<IRepository<EDamageType>, DamageTypeRepository>();
builder.Services.AddScoped<IRepository<Armor>, ArmorRepository>();
builder.Services.AddScoped<IRepository<EArmorType>, ArmorTypeRepository>();
builder.Services.AddScoped<IItemRepository, ItemRepository>();
builder.Services.AddScoped<IRepository<CharactersHasItem>, CharacterHasItemsRepository>();
builder.Services.AddScoped<AuthenticationStateProvider, ServerAuthenticationStateProvider>();
builder.Services.AddScoped<DialogService>();
builder.Services.AddScoped<NotificationService>();

builder.Services.AddCors(options => {
    options.AddDefaultPolicy(builder =>
        builder.WithOrigins("https://localhost:44338")
            .AllowAnyMethod()
            .AllowAnyHeader());
});


builder.Services.AddDefaultIdentity<ApplicationUser>(options => {
    options.Password.RequireDigit = false;
    options.Password.RequiredLength = 4;
    options.Password.RequireLowercase = false;
    options.Password.RequireUppercase = false;
    options.Password.RequireNonAlphanumeric = false;
    options.Password.RequiredUniqueChars = 2;
}).AddEntityFrameworkStores<CharacterSheetDbContext>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment()){
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}


app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();
app.UseAuthentication();
app.UseAuthorization();


//add cors
app.UseCors();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");
app.MapControllers();

app.Run();