using System.Diagnostics;
using AssignmentAppNetMhart2.Interfaces;
using AssignmentAppNetMhart2.Models;
using AssignmentAppNetMhart2.Responses;
using AssignmentAppNetMhart2.Enums;

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
}
