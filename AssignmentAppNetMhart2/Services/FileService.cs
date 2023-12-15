namespace AssignmentAppNetMhart2.Services;

public interface IFileService
{
    bool SaveContentToFile(string content);

    string GetContentFromFile();
}

public class FileService : IFileService 
{
    private readonly string _filePath;
}
