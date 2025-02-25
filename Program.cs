using Boutiquea.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddOpenApi();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.MapGet("/api/customers", () =>
{
    var customers = Enumerable.Range(1, 5).Select(index =>
        new Customer
        (

        ))
        .ToArray();
    return customers;
})
.WithName("GetCustomers");

app.MapGet("/api/orders", () =>
{
    var orders = Enumerable.Range(1, 5).Select(index =>
        new Order
        (

        ))
        .ToArray();
    return orders;
})
.WithName("GetOrders");

app.MapGet("/api/products", () =>
{
    var products = Enumerable.Range(1, 5).Select(index =>
        new Product
        (

        ))
        .ToArray();
    return products;
})
.WithName("GetProducts");

app.Run();
