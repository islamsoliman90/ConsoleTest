// See https://aka.ms/new-console-template for more information


var c1 = new { name = "ahmed", age = 5 };
var c2 = new { name = "ahmed s", age = 5 };
var c3 = new { name = "ahmed", age = 5, active = true };

Console.WriteLine(c1.GetType().Name);
Console.WriteLine(c2.GetType().Name);
Console.WriteLine(c3.GetType().Name);

Console.WriteLine(c1.Equals(c2));
