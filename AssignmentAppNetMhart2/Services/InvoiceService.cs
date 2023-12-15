using AssignmentAppNetMhart2.Repositories;

namespace AssignmentAppNetMhart2.Services;

internal class InvoiceService
{
    private readonly CustomerRepy customerRepy = new CustomerRepy();
    public void ShowAllCoustomer()
    {

        Console.WriteLine("Invoice Service: Get All Customers");
        foreach (var customer in customerRepy.GetAllFromList())
            Console.WriteLine($"{customer.Id, - 3} {customer.Name}");

        Console.ReadKey();

    }

}

