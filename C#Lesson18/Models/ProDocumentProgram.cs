using DocumentProgramNamespace;

namespace ProDocumentProgramNamespace
{
    public class ProDocumentProgram:DocumentProgram
    {
        public void OpenDocument()
        {
            Console.WriteLine("Document Opened");
        }

        public sealed override void EditDocument ()
        {
            Console.WriteLine("Document Edited");
        }

        public override void SaveDocument()
        {
            Console.WriteLine(" Document Saved in doc format, for pdf format buy Expert packet");
        }
    }
}
