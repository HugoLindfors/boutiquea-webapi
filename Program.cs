using Boutiquea.Data;
using Boutiquea.Models;
using System.Text.Json;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowSpecificOrigin",
        builder =>
        {
            builder.WithOrigins("http://localhost:3000") // Allow your Nuxt app's origin
                   .AllowAnyHeader()
                   .AllowAnyMethod();
        });
});

builder.Services.AddOpenApi();

var app = builder.Build();
app.UseCors("AllowSpecificOrigin");

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

// - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -

app.MapGet("/api/customers", () =>
{
    List<Customer> customers = CustomersList.customers;
    var customersArray = customers.ToArray();
    return customersArray;
})
.WithName("GetCustomers");

app.MapGet("/api/products", () =>
{
    List<Product> products = ProductsList.products;
    var productsArray = products.ToArray();
    return productsArray;
})
.WithName("GetProducts");

// - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -

app.Run();
