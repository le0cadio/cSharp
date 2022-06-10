using System;
using System.IO;

namespace TextEditor
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("What do you want?");
            Console.WriteLine("1. Open file");
            Console.WriteLine("2. Create new file");
            Console.WriteLine("0. Exit");
            var option = short.Parse(Console.ReadLine());

            switch (option)
            {
                case 0: Environment.Exit(0); break;
                case 1: Open(); break;
                case 2: Edit(); break;
                default: Menu(); break;

            }

        }
        static void Open()
        {
            Console.Clear();
            Console.WriteLine("what is the file path ?");
            var path = Console.ReadLine();

            using (var file = new StreamReader(path))
            {
                Console.Clear();
                var text = file.ReadToEnd();
                Console.WriteLine(text);
            }
            Console.WriteLine();
            Console.ReadLine();
            Menu();

        }
        static void Edit()
        {
            Console.Clear();
            Console.WriteLine("Insert your text: (ESC TO EXIT)");
            Console.WriteLine("----------------------------------------------------");
            var text = "";

            do
            {
                text += Console.ReadLine();
                text += Environment.NewLine;
                Console.Write(text);
            }
            while (Console.ReadKey().Key != ConsoleKey.Escape);
            {
                Save(text);
            }
        }
        static void Save(string text)
        {
            Console.Clear();
            Console.WriteLine("Which path to save the file?");
            var path = Console.ReadLine();

            using (var file = new StreamWriter(path))
            {
                file.Write(text);
            }
            Console.WriteLine("File saved at " + path);
            Menu();

        }
    }
}