using AssignmentAppNetMhart2.Models;
using AssignmentAppNetMhart2.Repositories;

namespace AssignmentAppNetMhart2.Services
{
    internal class OrderService
    {
        private readonly CustomerRepy customerRepy = new CustomerRepy();
        public void ShowAllCoustomer()
        {

            Console.WriteLine("Order Service: Get All Customers");
            foreach (var customer in customerRepy.GetAllFromList())
                Console.WriteLine($"{customer.Id - 3} {customer.Name}");

            Console.ReadKey();

        }
    }
}
