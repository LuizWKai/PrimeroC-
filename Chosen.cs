using Microsoft.VisualBasic;

namespace EditorHtml
{
    public static class Chosen
    {
        public static void UserChosen()
        {
            var option = Option();
            switch (option)
            {
                case 1: HandleFile.NewFile(); break;
                case 2: HandleFile.OpenFile(); break;
                case 3: HandleFile.DeleteFile(); break;
                case 0:
                    {
                        Console.Clear();
                        Console.WriteLine("Obrigado por usar nosso prorama!");
                        Environment.Exit(0);
                        break;
                    }
                default:
                    {
                        Menu.Show();
                        UserChosen();
                        break;
                    }
            }
        }
        public static short Option()
        {
            Console.SetCursorPosition(3, 11);
            Console.Write("Opção escolhida -->  ");
            var option = short.Parse(Console.ReadLine());
            Console.SetCursorPosition(0, 14);

            return option;
        }

    }
}