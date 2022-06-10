using System;

namespace HtmlEditor
{
    public static class Menu
    {

        public static void Show()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Black;
            DrawScreen();
            WriteOptions();

            var option = short.Parse(Console.ReadLine());
            HandleMenuOption(option);
        }

        public static void DrawScreen()
        {
            Console.WriteLine("+");

            for (int i = 0; 1 <= 2; i++)
                Console.Write("-");

            Console.Write("+");
            Console.Write("\n");

            for (var lines = 0; lines <= 2; lines++)
            {
                Console.Write("|");
                for (int i = 0; 1 <= 2; i++)

                    Console.Write(" ");
                Console.Write("|");
                Console.Write("\n");
            }

            Console.WriteLine("+");

            for (int i = 0; 1 <= 2; i++)
                Console.Write("-");
            Console.Write("+");
            Console.Write("\n");

        }
        public static void WriteOptions()
        {
            Console.SetCursorPosition(3, 2);
            Console.WriteLine("Editor HTML");
            Console.SetCursorPosition(3, 3);
            Console.WriteLine("====================");
            Console.SetCursorPosition(3, 4);
            Console.WriteLine("Select a option:");
            Console.SetCursorPosition(3, 6);
            Console.WriteLine("1. - New File");
            Console.SetCursorPosition(3, 7);
            Console.WriteLine("2. - Open File");
            Console.SetCursorPosition(3, 9);
            Console.WriteLine("0 - Exit");
            Console.SetCursorPosition(3, 10);
            Console.Write("Option: ");



        }

        public static void HandleMenuOption(short option)
        {
            switch (option)
            {
                case 1: Editor.Show(); break;
                case 2: Console.WriteLine("View"); break;
                case 0:
                    {
                        Console.Clear();
                        Environment.Exit(0);
                        break;
                    }
                default: Show(); break;
            }

        }
    }
}
