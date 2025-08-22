using System.ComponentModel.Design;
using System.Runtime.CompilerServices;
using System.Diagnostics;
using System.Text;
using System.IO;

namespace EditorHtml
{
    public class HandleFile()
    {
        public static void NewFile()
        {
            EditorMenu.MenuNewFile();
            var file = new StringBuilder();

            do
            {
                file.Append(Console.ReadLine());
                file.Append(Environment.NewLine);
            } while (Console.ReadKey().Key != ConsoleKey.Escape);

            Console.WriteLine("\n");
            Console.WriteLine(" Deseja salvar o arquivo? ");
            Console.WriteLine("1- Sim");
            Console.WriteLine("2- Não");
            var salvar = short.Parse(Console.ReadLine());

            if (salvar == 1)
            {
                Console.Clear();
                string conteudoSalvar = file.ToString();
                Console.WriteLine("Qual vai ser o nome do arquivo? (ex: nomeArquivo.txt)");
                var nameDocument = Console.ReadLine();

                try
                {
                    File.WriteAllText(nameDocument, conteudoSalvar);
                    Console.Clear();
                    Console.WriteLine($"Texto salvo com sucesso em: {Path.GetFullPath(nameDocument)}");
                }
                catch
                {
                    Console.Clear();
                    Console.WriteLine($"Texto salvo com sucesso em: {Path.GetFullPath(nameDocument)}");
                }
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Pressione ENTER para confirmar");
                if (Console.ReadKey().Key == ConsoleKey.Enter)
                {
                    Menu.Show();
                    Chosen.UserChosen();
                }

            }

            Menu.Show();
            Chosen.UserChosen();

        }
        public static void OpenFile()
        {
            EditorMenu.MenuOpenFile();
            string filePath = Console.ReadLine();
            string fileName = "notepad";

            ProcessStartInfo psi = new ProcessStartInfo();
            psi.FileName = fileName;
            psi.Arguments = $"\"{filePath}\"";
            psi.UseShellExecute = true;

            try
            {
                Process.Start(psi);
                Console.WriteLine($"Arquivo '{filePath}' foi aberto com sucesso!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao tentar abrir o arquivo: {ex.Message}");
            }

            Menu.Show();
            Chosen.UserChosen();
        }
        public static void DeleteFile()
        {
            EditorMenu.DeleteFile();
            string fileDelete = Console.ReadLine();
            Console.WriteLine($"Você tem certeza que deseja deletar o arquivo {fileDelete}?");
            Console.WriteLine($"Se sim pressione ENTER, caso não queira, pressione ESC");
            if (Console.ReadKey().Key == ConsoleKey.Enter)
                if (File.Exists(fileDelete))
                {
                    try
                    {
                        File.Delete(fileDelete);
                        Console.WriteLine($"Arquivo {fileDelete} foi deletado com sucesso");
                    }
                    catch (IOException)
                    {
                        Console.WriteLine("Erro de IO ao excluir o arquivo");
                    }
                    catch (UnauthorizedAccessException)
                    {
                        Console.WriteLine("Acesso não autorizado para excluir o arquivo");
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Ocorreu um erro inesperado!");
                    }
                }
                else
                {
                    Console.WriteLine("Arquivo não encontrado");
                }
            else
            {
                Console.Clear();
                Console.WriteLine("Delete cancelado !");
                Menu.Show();
                Chosen.UserChosen();
            }

            Console.Clear();
            Menu.Show();
            Chosen.UserChosen();
        }
        
    }
}