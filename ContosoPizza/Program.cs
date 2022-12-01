
using ContosoPizza.Data;
using ContosoPizza.Models;

using var context = new ContosoPizzaContext();


var veggiSpecial = context.Products
    .Where(p => p.Name == "Veggie Special Pizza")
    .FirstOrDefault();

if (veggiSpecial is Product)
{
    veggiSpecial.Price = 10.99M;
    //context.Remove(veggiSpecial);       //Delete
}

context.SaveChanges();

var prosucts = context.Products
    .Where(p => p.Price > 10.00M)
    .OrderBy(p => p.Name);

foreach(var p in prosucts)
{
    Console.WriteLine($"Name {p.Name}");
    Console.WriteLine(new string('-', 20));
}

//using var ts = context.Database.BeginTransaction();
//{
//    var veggieSpecial = new Product()
//    {
//        Name = "Veggie Special Pizza",
//        Price = 9.99M
//    };
//    context.Products.Add(veggieSpecial);

//    var deluxMeat = new Product()
//    {
//        Name = "Deluxe Meat Pizza",
//        Price = 12.99M
//    };
//    context.Products.Add(deluxMeat);

//    context.SaveChanges();
//    ts.Commit();
//}

