namespace AssignmentAppNetMhart2.Services;


public interface IFileService
{
    string _filePatch { get; set; }
       
    bool SaveContenctToFile(string content);

    string GetContenctFile();
}

public class FileService : IFileService
{
    public string _filePatch { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

    public string GetContenctFile()
    {
        throw new NotImplementedException();
    }

    public bool SaveContenctToFile(string content)
    {
        throw new NotImplementedException();
    }
}
