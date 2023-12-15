namespace AssignmentAppNetMhart2.Services;

public interface IFileSetup
{
    bool SaveContentToFile(string content);

    string GetContentFromFile();  
}

public class FileSetup(string fileSetup) : IFileSetup
{
    private readonly string _filePath;

    public string GetContentFromFile()
    {
        try
        {
            if (File.Exists(_filePath))
            {
                using var sr = new StreamReader(_filePath);
                return sr.ReadToEnd();
            }

        }
        catch(Exception ex) { Debug.WriteLine(ex.Message); }
        return null;
    }   

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
}
