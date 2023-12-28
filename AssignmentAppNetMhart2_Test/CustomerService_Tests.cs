using AssignmentAppNetMhart2.Interfaces;
using AssignmentAppNetMhart2.Models;
using AssignmentAppNetMhart2.Services;

namespace AssignmentAppNetMhart2_Test;

public class CustomerService_Tests
{
    [Fact]
    public void AddToListShould_AddOneCustomerToCustomerList_ThenReturnTrue()
    {
        //Arrange
        ICustomer customer = new Customer { FirstName = "", LastName = "", Email = "" };
        ICustomerService customerService = new CustomerService();
        //Act - 
        bool result = customerService.AddToList(customer);

        //Assert
        Assert.True(result );

    }


    [Fact]
    public void GetAllFromListShould_GetAllCustomersInCustomerList_ThenReturnListOfCustomer()
    {
        //Arrange
        ICustomerService customerService = new CustomerService();
        ICustomer customer = new Customer { FirstName = "", LastName = "", Email = "" };
        customerService.AddToList(customer);
        //Act
        IEnumerable<ICustomer> result = customerService.GetAllFromList();
        //Assert
        Assert.NotNull(result);
        Assert.True(((IEnumerable<ICustomer>)result).Any());
    }
}