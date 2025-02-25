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

List<Customer> customers = [
    new(0, "Matti Meikäläinen"),
    new(1, "Maija Meikäläinen"),
];

List<Product> products = [
    new(0, "Sibelius Symphony Speakers", 5500, 100),
    new(1, "Kelo Sauna Wellness Kit", 4200, 50),
    new(2, "Moominvalley Board Game Collection", 950, 500),
    new(3, "Arctic Bloom Skincare Line", 450, 800),
];

app.MapGet("/api/customers", () =>
{
    var customersArray = customers.ToArray();
    return customersArray;
})
.WithName("GetCustomers");

app.MapGet("/api/products", () =>
{
    var productsArray = products.ToArray();
    return productsArray;
})
.WithName("GetProducts");

// - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -

app.Run();
