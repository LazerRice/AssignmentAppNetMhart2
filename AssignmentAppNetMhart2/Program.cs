using AssignmentAppNetMhart2.Models;
using AssignmentAppNetMhart2.Services;

var customer_1 = new Customer
{
    FirstName = "Mhart",
    LastName = "Canoy",
    Email = "mhart@domain.com"
};

var customer_2 = new Customer
{
    FirstName = "Kurt",
    LastName = "Roland",
    Email = "Kurt@domain.com"
};

var customer_3 = new Customer
{
    FirstName = "Kalle",
    LastName = "Anka",
    Email = "kalle@domain.com"
};


var customerService = new CustomerService();
customerService.AddCustomerToList(customer_1);
customerService.AddCustomerToList(customer_2);
customerService.AddCustomerToList(customer_3);