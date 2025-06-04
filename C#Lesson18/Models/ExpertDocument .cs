using ProDocumentProgramNamespace;
namespace ExpertDocumentNamespace
{
    public class ExpertDocument :ProDocumentProgram
    {
        public void OpenDocument()
        {
            Console.WriteLine("Document Opened");
        }

        public void EditDocument()
        {
            Console.WriteLine("Document Edited");
        }

        public void SaveDocuemnt()
        {
            Console.WriteLine(" Document Saved in pdf format");
        }
    }
}
