//Denna kod är till för att vi ska kunna hämta och skriva information till en file. För att kunna spara och logga information smidigare. Det sparas till en Json. 
// Vi har en "try catch" på båda förfrågningarna. Detta är för att snabb kunna fånga upp eventuella fel.  

using System.Diagnostics;

namespace AssignmentAppNetMhart2.Services;

public interface IFileService
{
    bool SaveContentToFile(string content);

    string GetContentFromFile();
}

public class FileService(string filePath) : IFileService 
{
    private readonly string _filePath = filePath;


    public bool SaveContentToFile(string content)
    {
        try
        {
            using (var sw = new StreamWriter(_filePath)) 
            {
                sw.WriteLine(content);
            }

            return true;
        }
        catch (Exception ex) { Debug.WriteLine(ex.Message); }
        return false;
    }   

    public string GetContentFromFile()
    {
        try
        {
            if(File.Exists(_filePath))
            {
                File.ReadAllLines(_filePath);
            }
        }
        catch (Exception ex){ Debug.WriteLine(ex.Message); }
        return null!;
    }

   
}
