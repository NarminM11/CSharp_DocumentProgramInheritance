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
            Console.WriteLine("↑ ↓:\n");

            for (int i = 0; i < options.Length; i++)
            {
                if (i == selected)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"> {options[i].ToUpper()}");
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
        int selectedIndex = ShowArrowMenu(versions);
        string selectedVersion = versions[selectedIndex];

        DocumentProgram document;

        switch (selectedVersion)
        {
            case "pro":
                document = new ProDocumentProgram();
                break;
            case "expert":
                document = new ExpertDocument();
                break;
            default:
                document = new BasicDocumentProgram();
                break;
        }

        Console.Clear();
        document.OpenDocument();
        document.EditDocument();
        document.SaveDocument();

        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }
}
