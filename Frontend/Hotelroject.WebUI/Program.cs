using FluentValidation;
using FluentValidation.AspNetCore;
using HotelProjectDataAccessLayer.Concrete;
using HotelProjectEntityLayer.Concrete;
using Hotelroject.WebUI.Dtos.GuestDto;
using Hotelroject.WebUI.Mapping;
using Hotelroject.WebUI.MappingFrontend;
using Hotelroject.WebUI.ValidationRules.GuestValidationRules;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.


builder.Services.AddControllersWithViews().AddFluentValidation();

builder.Services.AddAutoMapper(typeof(AutoMapperConfigFrontend));
builder.Services.AddDbContext<Context>();
builder.Services.AddIdentity<AppUser, AppRole>().AddEntityFrameworkStores<Context>();
builder.Services.AddHttpClient();

//For validation
builder.Services.AddTransient<IValidator<CreateGuestDto>, CreateGuestValidator>();
builder.Services.AddTransient<IValidator<UpdateGuestDto>, UpdateGuestValidator>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
	app.UseExceptionHandler("/Home/Error");
}

app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
	name: "default",
	pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
