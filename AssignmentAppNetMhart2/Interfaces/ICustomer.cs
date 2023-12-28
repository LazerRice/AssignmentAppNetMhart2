namespace AssignmentAppNetMhart2.Interfaces;

public interface ICustomer
{
    int Id { get; set; }
    string Email { get; set; }
    string FirstName { get; set; }
    string LastName { get; set; }
}