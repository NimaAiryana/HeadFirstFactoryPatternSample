using HeadFirstFactoryPatternSample.Abstractions;
using HeadFirstFactoryPatternSample.PizzaStores;

Console.WriteLine("Hello, Factory Pattern :D");
Console.WriteLine();

PizzaStore nyPizzaStore = new NYPizzaStore();
PizzaStore chicagoPizzaStore = new ChicagoPizzaStore();

Pizza ethanPizza = nyPizzaStore.OrderPizza("Cheese");
Console.WriteLine($"Ethan ordered a {ethanPizza.GetName()}");

Console.WriteLine();

Pizza joelPizza = chicagoPizzaStore.OrderPizza("Cheese");
Console.WriteLine($"Joel ordered a {joelPizza.GetName()}");
