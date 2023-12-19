namespace AssignmentAppNetMhart2.Models;

public interface ICustomer
{
    string Email { get; set; }
    string FirstName { get; set; }
    string LastName { get; set; }
}

public class Customer : ICustomer
{
    public string Email { get; set; } = null!;
    public string LastName { get; set; } = null!;
    public string FirstName { get; set; } = null!;
}

