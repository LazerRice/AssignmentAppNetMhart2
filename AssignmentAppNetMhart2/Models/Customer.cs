namespace AssignmentAppNetMhart2.Models;

public interface ICustomer
{
    string Email { get; set; }
    int Id { get; set; }
    string Name { get; set; }
}

public class Customer : ICustomer
{
    public string Email { get; set; } = null!;
    public int Id { get; set; }
    public string Name { get; set; } = null!;
}

