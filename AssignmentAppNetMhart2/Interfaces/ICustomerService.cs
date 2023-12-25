using AssignmentAppNetMhart2.Models;
using AssignmentAppNetMhart2.Responses;
using AssignmentAppNetMhart2.Services;

namespace AssignmentAppNetMhart2.Interfaces;

//Crud
public interface ICustomerService
{
    IServiceResult AddCustomerToList(ICustomer customer);

    IServiceResult DeleteCustomerToList(Func<Customer, bool> predicate);

    IServiceResult GetCustomerToList(Func<Customer, bool> predicate);

    IServiceResult GetCustomersToList();

    IServiceResult UpdateCustomerToList(ICustomer customer);


}

//Func är en fuktion så man kan söka med Lambda.  (Jag tänker på Half-Life och CS 1.3 or 1.6 :D)
