using System;
using System.Security.Cryptography.X509Certificates;
namespace EditorHtml
{
    public static class Menu
    {
        public static void Show()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            DrawScreen();
        }
        public static void DrawScreen()
        {
            ParteCimaEBaixo();
            Laterais();
            Options();
            ParteCimaEBaixo();

        }
        public static void ParteCimaEBaixo()
        {
            for (int i = 0; i <= 31; i++)
            {
                if (i == 15 || i == 16)
                {
                    Console.Write("//");
                }
                else
                {
                    Console.Write("-");
                }
            }
            Console.Write("\n");
        }
        public static void Laterais()
        {
            for (int lines = 0; lines <= 12; lines++)
            {
                Console.Write("|");
                for (int j = 0; j <= 31; j++)
                {
                    Console.Write(" ");
                }
                Console.Write("|");
                Console.Write("\n");
            }
        }
        public static void Options()
        {
            Console.SetCursorPosition(11, 2);
            Console.WriteLine("Editor HTML");
            Console.SetCursorPosition(3, 3);
            Console.WriteLine("============================");
            Console.SetCursorPosition(3, 4);
            Console.WriteLine("Selecione uma opção abaixo:");
            Console.SetCursorPosition(3, 6);
            Console.WriteLine("1 - Novo Arquivo");
            Console.SetCursorPosition(3, 7);
            Console.WriteLine("2 - Abrir");
            Console.SetCursorPosition(3, 8);
            Console.WriteLine("3 - Deletar");
            Console.SetCursorPosition(3, 9);
            Console.WriteLine("0 - Sair");
            Console.SetCursorPosition(0, 13);
        }
    }
    public static class EditorMenu
    {
        public static void MenuNewFile()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkYellow;

            Console.SetCursorPosition(12, 1);
            Console.WriteLine("BEM VINDO AO EDITOR");
            Console.SetCursorPosition(7, 2);
            Console.WriteLine("============================");
            Console.WriteLine("\n");
            Console.WriteLine("Escreva a baixo seu texto: (Aperte ESC para terminar)");
            Console.WriteLine("\n");
        }
        public static void MenuOpenFile()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkGreen;

            Console.SetCursorPosition(12, 1);
            Console.WriteLine("BEM VINDO AO EDITOR");
            Console.SetCursorPosition(7, 2);
            Console.WriteLine("============================");
            Console.WriteLine("\n");
            Console.WriteLine("Escreva o caminho do arquivo que deseja abrir: ");
            Console.WriteLine(@"Ex: C:\caminho\para\seu\arquivo.txt");
            Console.WriteLine("\n");
        }

        public static void DeleteFile()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkRed;

            Console.SetCursorPosition(12, 1);
            Console.WriteLine("BEM VINDO AO EDITOR");
            Console.SetCursorPosition(7, 2);
            Console.WriteLine("============================");
            Console.WriteLine("\n");
            Console.WriteLine("Escreva o caminho do arquivo que deseja deletar: ");
            Console.WriteLine(@"Ex: C:\caminho\para\seu\arquivo.txt");
            Console.WriteLine("\n");
        }
    }
}
