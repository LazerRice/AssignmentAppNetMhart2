using System.Diagnostics;
using AssignmentAppNetMhart2.Interfaces;
using AssignmentAppNetMhart2.Models;
using AssignmentAppNetMhart2.Responses;
using AssignmentAppNetMhart2.Enums;
using Newtonsoft.Json;

namespace AssignmentAppNetMhart2.Services;


public class CustomerService : ICustomerService
{
    private static readonly List<ICustomer> _customer = [];
    public IServiceResult AddCustomerToList(ICustomer customer)
    {
        IServiceResult response = new ServiceResult();

        try
        {
            if (!_customer.Any(x => x.Email == customer.Email))
            {
                _customer.Add(customer);
                response.Status = Enums.ServiceStatus.SUCCESSED;
            }
            else
            {
                response.Status = Enums.ServiceStatus.ALREADY_EXIST;
            }
        }
        catch (Exception ex)
        {
            Debug.WriteLine(ex.Message);
            response.Status = Enums.ServiceStatus.FAILED;
            response.Result = ex.Message;
        }

        return response;
    }

    public IServiceResult DeleteCustomerToList(Func<Customer, bool> predicate)
    {
        throw new NotImplementedException();
    }

    public IServiceResult GetCustomersToList()
    {
        IServiceResult response = new ServiceResult();

        try
        {
            response.Status = Enums.ServiceStatus.SUCCESSED;
            response.Result = _customer;
        }
        catch (Exception ex)
        {
            Debug.WriteLine(ex.Message);
            response.Status = Enums.ServiceStatus.FAILED;
            response.Result = ex.Message;
        }

        return response;
    }

    public IServiceResult GetCustomerToList(Func<Customer, bool> predicate)
    {
        throw new NotImplementedException();
    }

    public IServiceResult UpdateCustomerToList(ICustomer customer)
    {
        throw new NotImplementedException();
    }

    private readonly FileService _fileService = new FileService(@"C:\ESS\C#Sharp\contenct.json");

    private List<Customer> _customerList = new List<Customer>();

    public void AddCustomerToList(Customer customer)
    {
        try
        {
            if (!_customerList.Any(x => x.Email == customer.Email))
            {
                _customerList.Add(customer);

                _fileService.SaveContenctToFile(JsonConvert.SerializeObject(_customerList));
            }
        }
        catch (Exception ex){ Debug.WriteLine(ex.Message); }
    }

    public IEnumerable<Customer> GetCustomerToList()
    {
        try
        {
            var content = _fileService.GetContenctFile();
            if (!string.IsNullOrEmpty(content)) 
            {
                _customerList = JsonConvert.DeserializeObject<List<Customer>>(content)!;
            }
        }
        catch (Exception ex) { Debug.WriteLine(ex.Message); }

        return _customerList;
    }

    public bool AddToList(ICustomer customer)
    {
        try
        {
            customer.Id = _customerList.Count + 1;

            _customerList.Add(customer);
            return true;
        }
        catch (Exception ex) { Debug.WriteLine(ex.Message); }
        return false;
    }

    public IServiceResult AddToList()
    {
        throw new NotImplementedException();
    }

    public IEnumerable<ICustomer> GetAllFromList()
    {
        try
        {
            return _customerList;
        }
        catch (Exception ex) { Debug.WriteLine(ex.Message); }
        return null!;
    }
}

    
