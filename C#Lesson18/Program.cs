using DocumentProgramNamespace;
using ExpertDocumentNamespace;
using ProDocumentProgramNamespace;

class Program
{
    static int ShowArrowMenu(string[] options)
    {
        int selected = 0;
        ConsoleKeyInfo key;

        do
        {
            Console.Clear();
            Console.WriteLine("Use ↑ ↓ arrows to navigate, Enter to select:\n");

            for (int i = 0; i < options.Length; i++)
            {
                if (i == selected)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"> {options[i]}");
                    Console.ResetColor();
                }
                else
                {
                    Console.WriteLine($"  {options[i]}");
                }
            }

            key = Console.ReadKey(true);

            if (key.Key == ConsoleKey.UpArrow)
                selected = (selected == 0) ? options.Length - 1 : selected - 1;
            else if (key.Key == ConsoleKey.DownArrow)
                selected = (selected == options.Length - 1) ? 0 : selected + 1;

        } while (key.Key != ConsoleKey.Enter);

        return selected;
    }

    static void Main()
    {
        string[] versions = { "basic", "pro", "expert" };
        int selected = ShowArrowMenu(versions);

        string selectedKey = versions[selected];

        DocumentProgram docProgram;

        if (selectedKey == "pro")
            docProgram = new ProDocumentProgram();
        else if (selectedKey == "expert")
            docProgram = new ExpertDocument();
        else
            docProgram = new DocumentProgramImplementation();

        Console.Clear();
        docProgram.OpenDocument();
        docProgram.EditDocument();
        docProgram.SaveDocument();

        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }
}
class DocumentProgramImplementation : DocumentProgram
{
}