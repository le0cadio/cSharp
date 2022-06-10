using System;

namespace HtmlEditor
{
    public static class Editor
    {
        public static void Show()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.WriteLine("EDITOR MODE");
            Console.WriteLine("====================");
            Start();
        }

        public static void Start()
        {
            var file = Array.Empty<string>();

            do
            {
                file.Append(Console.ReadLine());
                file.Append(Environment.NewLine);
            } while (Console.ReadKey().Key != ConsoleKey.Escape);

            Console.WriteLine("====================");
            Console.WriteLine("Want save your file? (y/n)");
            Viewer.Show(file.ToString());
            var key = Console.ReadKey();

            if (key.Key == ConsoleKey.Y)
            {
                Console.WriteLine("====================");
                Console.WriteLine("Enter file name:");
                var fileName = Console.ReadLine();
                System.IO.File.WriteAllText(fileName, file.ToString());
            }
            else
            {
                Console.WriteLine("====================");
                Console.WriteLine("File not saved");
            }

        }
    }
}