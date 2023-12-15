using AssignmentAppNetMhart2.Services;
using AssignmentAppNetMhart2.Models;



var customerService = new CustomerService();
customerService.AddCustomer(new Customer { Name = "Mhart Canoy" });
customerService.AddCustomer(new Customer { Name = "Kurt Roland" });

foreach (var customer in customerService.GetAll())
    Console.WriteLine(customer.Name);




