// See https://aka.ms/new-console-template for more information


using ConsoleTest.Extentions;
using SeedData;


var cats = GetData.GetCategories(GetData.GetCustomers());

//var list = cats.Select(c => c.customer);
//foreach (var c in list)
//{
//    foreach (var cust in c)
//    {
//        Console.WriteLine(cust.id + " : " + cust.name);
//    }
//}
var cust = GetData.GetCustomers().Where(d => d.categoryId == 2);

var list = cats.Where(c => c.Id == 2);
foreach (var c in cust)
{
    Console.WriteLine(c.id + " : " + c.name);
}
Console.WriteLine("=============");
var GetCust = GetData.GetCustomers().getCustomers(c => c.name.Contains("ahmed"));
foreach (var c in GetCust)
{
    Console.WriteLine($" name {c.name} : {c.id}");
}
Console.WriteLine("=============");

var ahmed = GetData.GetCustomers().getByName("ahmed");
foreach (var c in ahmed)
{
    Console.WriteLine($" name {c.name} : {c.id}");
}
