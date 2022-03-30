using System;

namespace EditorHTML
{
    public static class Menu
    {
        public static void Show()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Black;

            DrawScreen();
            WriteOptions();

            var option = short.Parse(Console.ReadLine());
            HandleMenuOption(option);

        }
        public static void DrawScreen()
        {
            Lines();
            column();
            Lines();

        }
        public static void Lines()
        {
            Console.Write("+");
            for (int i = 0; i <= 30; i++)
                Console.Write("=");

            Console.Write("+");
            Console.Write("\n");
        }

        public static void column()
        {
            for (int column = 0; column <= 10; column++)
            {
                Console.Write("|");
                for (int i = 0; i <= 30; i++)
                    Console.Write(" ");

                Console.Write("|");
                Console.Write("\n");
            }
        }

        public static void WriteOptions()
        {
            Console.SetCursorPosition(1, 0);
            Console.WriteLine("         EDITOR HTML");
            Console.SetCursorPosition(1, 1);
            Console.WriteLine("===============================");
            Console.SetCursorPosition(3, 2);
            Console.WriteLine("SELECIONE UMA OPÇÃO ABAIXO:");
            Console.SetCursorPosition(4, 4);
            Console.WriteLine("[1] - NOVO ARQUIVO");
            Console.SetCursorPosition(4, 6);
            Console.WriteLine("[2] - ABRIR");
            Console.SetCursorPosition(4, 7);
            Console.WriteLine("[0] - SAIR");
            Console.SetCursorPosition(3, 8);
            Console.Write("OPÇÃO: ");

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
