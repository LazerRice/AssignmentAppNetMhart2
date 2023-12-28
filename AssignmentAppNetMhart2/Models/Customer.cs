using AssignmentAppNetMhart2.Interfaces;
namespace AssignmentAppNetMhart2.Models;


public class Customer : ICustomer
{
    public string Email { get; set; } = null!;
    public string LastName { get; set; } = null!;
    public string FirstName { get; set; } = null!;
    int ICustomer.Id { get; set; } 
}

