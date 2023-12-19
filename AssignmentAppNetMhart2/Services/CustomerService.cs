using System.Diagnostics;
using AssignmentAppNetMhart2.Models;
using Newtonsoft.Json;

namespace AssignmentAppNetMhart2.Services;

internal class CustomerService
{
    
    private readonly FileService _fileSetup = new FileService(@"C:\ESS\C#Sharp\content.json");

    //Här ändrar vi från readonly till privat för att  vi ska kunna hämta lista och läsa den. 
    private List<Customer> _customerList = new List<Customer>();

    
    public void AddCustomerToList(Customer customer)
    {

        try
        {
            if (!_customerList.Any(x => x.Email == customer.Email))
            {
                _customerList.Add(customer);
                _fileSetup.SaveContentToFile(JsonConvert.SerializeObject(_customerList));
            }
        } // Denna catch kollar så att det finns något att hämta. 
        catch (Exception ex) { Debug.WriteLine(ex.Message); }

    }
    // IEnumerbla är den läsbar lista, som inte går att ändra. 
    public IEnumerable<Customer> GetCustomerFromlist()
    {
        try
        {        //Denna skrivs för att hämta den senaste lite och kollar om det finns någon lista att hämta. 
                var content = _fileSetup.GetContentFromFile();
                if (!string.IsNullOrEmpty(content))
                {
                    _customerList = JsonConvert.DeserializeObject<List<Customer>>(content)!;
                }
                
        }
        catch (Exception ex) { Debug.WriteLine(ex.Message); }

        return _customerList;
    }   



}

