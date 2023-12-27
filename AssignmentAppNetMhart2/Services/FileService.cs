using System.Data.SqlTypes;
using System.Diagnostics;

namespace AssignmentAppNetMhart2.Services;


public interface IFileService
{
           //Opps stavade fel här. Vill inte förstöra något.Låter det stå kvar. 
    bool SaveContenctToFile(string content);

    string GetContenctFile();
}
// Viktigt att alltid köra en "try catch" när en handling ska utföras. 
// Detta är för at man ska fånga upp eventuella fel.
public class FileService(string filePath) : IFileService
{
    private readonly string _filePath = filePath;

    //Här får man bara emot två värden. Sant eller falskt.
    public bool SaveContenctToFile(string content) 
    {
        try
        {   //Vi använder StreamWrit för att kunna spara ner data till en fil. 
            // I detta fall till en json fil. Vilket stödjer flera programmeringsspråk. 
            using (var sw = new StreamWriter(_filePath)) { }

                return true;
        }
        catch (Exception ex) { Debug.WriteLine(ex.Message); }
        return false;


    }
    //Här är det ett ord som har ett värde. Sätter "null" värde då kan man 
    //test sin kod. 
    public string GetContenctFile()
    {
        try
        {

        }
        catch (Exception ex) { Debug.WriteLine(ex.Message); }
        return null!;
    }

   
}
