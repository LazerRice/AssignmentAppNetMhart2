using System.Diagnostics;
using System.Net.Http.Json;
using System.Text.Json.Serialization;
using AssignmentAppNetMhart2.Models;
using AssignmentAppNetMhart2.Repositories;

namespace AssignmentAppNetMhart2.Services;

internal class CustomerService
{
    private readonly CustomerRepy customerRepy = new CustomerRepy();
    private readonly FileSetup _fileSetup = new FileSetup(@"C:\ESS\C#Sharp\content.json");
    private readonly List<Customer> _customerList = new List<Customer>();

    
    public void AddCustomer(Customer customer)
    {

        Console.WriteLine($"Coustomer Service: Add Customer {customer.Name} To List");
        customerRepy.AddToList(customer);
        Console.ReadKey();

        try
        {
            if (!_customerList.Any(x => x.Email == customer.Email))
            {
                _customerList.Add(customer);
                _fileSetup.SaveContenToFile(JsonContent.SerializeObject(_customerList));
            }
        }
        catch (Exception ex) { Debug.WriteLine(ex.Message); }

    }

    public IEnumerable<Customer> GetAll() => customerRepy.GetAllFromList(); 

    public IEnumerable<Customer> GetCustomerFromlist()
    {
        try
        {
                var content = FileSetup.GetContentFromFile();
                _customerList = JsonConverter.DeserializeObject<List<Coustmer>>(content);
        }
        catch (Exception ex) { Debug.WriteLine(ex.Message); }

        return _customerList;
    }   



}

