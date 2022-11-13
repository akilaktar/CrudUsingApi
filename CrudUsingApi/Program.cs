using CrudUsingApi.Models;
using CrudUsingApi.Repository;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddDbContext<EmployeeContext>(option => option.UseSqlServer(builder.Configuration.GetConnectionString("Sqlcon")));
builder.Services.AddScoped<IEmployeeRepository, EmployeeRepository>();
builder.Services.AddSwaggerGen(c=>c.SwaggerDoc("v1",new Microsoft.OpenApi.Models.OpenApiInfo
{
    Title="AspnetApi",
    Version="v1",
    Description="Emplyee Api realated",
}));   // For documentation
builder.Services.AddControllers(); //only for api 

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();
app.UseEndpoints(endpoints => endpoints.MapControllers());   //for route  
app.UseSwagger();

app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "swagger Api"));//for swagger url
app.Run();
