using AssignmentAppNetMhart2.Responses;

namespace AssignmentAppNetMhart2.Interfaces;

//Crud
public interface ICustomerService
{
    ServiceResult AddCustomerToList();

    ServiceResult DeleteCustomerToList();

    ServiceResult GetCustomerToList();

    ServiceResult UpdateCustomerToList();


}
