using Boutiquea.Data;
using Boutiquea.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddOpenApi();

var app = builder.Build();

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
