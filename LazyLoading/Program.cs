using LazyLoading;
using static System.Console;
var customer = new Customer(10) {Id=10 };
Console.WriteLine(customer.Addresses.IsValueCreated);
var addresses = customer.Addresses.Value;
Console.WriteLine(customer.Addresses.IsValueCreated);
_ =ReadKey();
