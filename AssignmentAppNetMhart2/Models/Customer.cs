namespace AssignmentAppNetMhart2.Models;

internal interface ICustomer
{
    string Email { get; set; }
    int Id { get; set; }
    string Name { get; set; }
}

internal class Customer : ICustomer
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Email { get; set; } = null!;
}

