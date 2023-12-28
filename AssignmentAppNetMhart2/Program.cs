using AssignmentAppNetMhart2.Services;

var menuService = new MenuSetup();

menuService.ShowMainMenu();

var customerService = new CustomerService();

Console.WriteLine("List 1");
var list1 = customerService.GetCustomerToList();
foreach (var customer in list1)
{
    Console.WriteLine($"{customer.FirstName} {customer.LastName} <{customer.Email}>");
}

Console.ReadKey();
Console.WriteLine();


Console.WriteLine("List 1 - Upgraded");


customerService.AddCustomerToList(new AssignmentAppNetMhart2.Models.Customer()

foreach (var customer in list1)
{
    Console.WriteLine($"{customer.FirstName} {customer.LastName} <{customer.Email}>");
}


Console.ReadKey();
Console.WriteLine();


Console.WriteLine("List 2");
var list2  = customerService.GetCustomersToList();
foreach (var customer in list2)
{
    Console.WriteLine($"{customer.FirstName} {customer.LastName} <{customer.Email}>");
}

Console.ReadKey();
Console.WriteLine();