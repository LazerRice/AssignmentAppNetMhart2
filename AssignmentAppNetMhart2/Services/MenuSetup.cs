//Menu class detta är vår interface.

namespace AssignmentAppNetMhart2.Services;
using AssignmentAppNetMhart2.Interfaces;
using AssignmentAppNetMhart2.Models;

public interface IMenuSetup
{
    void ShowMainMenu();

    void ShowAddCustomer();

    void ShowDeleteCustomer();

    void ShowCustomerDetailList();

    void ShowUpdateCustomerList();

    void ShowViewCustomerOption();


}

public class MenuSetup : IMenuSetup
{
    public void ShowAddCustomer()
    {
        ICustomer customer = new Customer();
    }

    public void ShowCustomerDetailList()
    {
        throw new NotImplementedException();
    }

    public void ShowDeleteCustomer()
    {
        throw new NotImplementedException();
    }

    public void ShowMainMenu()
    {
        while (true) 
        {

            DisplayMenuTitle("Menu Option");
            Console.WriteLine($"{"1.", -4}Add New Customer");
            Console.WriteLine($"{"2.",-4}Wiew Customer List");
            Console.WriteLine($"{"3.",-4}Delete Customer");
            Console.WriteLine($"{"0.",-4}Exit Application");
            Console.WriteLine();
            Console.Write("Enter Menu Option");
            var option = Console.ReadLine();

            switch(option)
            {
                case "1":
                    ShowAddCustomer();
                    break;  
                case "2":
                    ShowViewCustomerOption();
                    break;
                case "3":
                    ShowDeleteCustomer();
                    break;
                case "0":
                    ShowExitApplicationOption();
                    break;

                default:
                    Console.WriteLine("Wrong try again");
                    break;

            }


            Console.ReadKey();


        }

    }
    //Denna logic gör att du kan lämna appen. Den jämför vilka värden som finns och inte finns. 
    private void ShowExitApplicationOption()
    {
        Console.Clear();
        Console.Write("Do you wont to Exit the app? (y/n):");
        var option = Console.ReadLine() ?? "";

        if (option.Equals("y", StringComparison.OrdinalIgnoreCase)); 
    
    }
    public void ShowUpdateCustomerList()
    {
        throw new NotImplementedException();
    }

    public void ShowViewCustomerOption()
    {
        throw new NotImplementedException();
    }


    //Detta är en kod som används ofta så slipper man skriva om den varje gång den ska användas.
    private void DisplayMenuTitle (string title)
    {
        Console.Clear();
        Console.WriteLine($"##{title}##");
        Console.WriteLine();
    }


}
