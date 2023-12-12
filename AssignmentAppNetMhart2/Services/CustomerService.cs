using AssignmentAppNetMhart2.Models;
using AssignmentAppNetMhart2.Repositories;

namespace AssignmentAppNetMhart2.Services;

internal class CustomerService
{
    private readonly CustomerRepy customerRepy = new CustomerRepy();
    public void AddCustomer(Customer customer)
    {

        Console.WriteLine("Coustomer Service: Add Customer To List");
        customerRepy.AddToList(customer);

        Console.ReadKey();

    }
    }
