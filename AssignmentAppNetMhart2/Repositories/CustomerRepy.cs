using AssignmentAppNetMhart2.Models;

namespace AssignmentAppNetMhart2.Repositories;

internal class CustomerRepy
{

    private List<Customer> _customerList = [];

    public void AddToList(Customer customer)
    {
        customer.Id = _customerList.Count + 1;
        _customerList.Add(customer);
    }

    public IEnumerable<Customer> GetAllFromList()
    {
        return _customerList;
    }
}

