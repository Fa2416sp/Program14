using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Program14
{
    class Program
    {
        static void Main(string[] args)
        {
            string s;
            string[] b = new string[20];
            Random rnd = new Random();
            try
            {
                Console.WriteLine("Создание и заполнение файлов");
                Console.Clear();
                Directory.CreateDirectory("Tabota_Folder");
                StreamWriter surname = new StreamWriter("Tabota_Folder\\MexName.txt", false);
                StreamWriter age = new StreamWriter("Tabota_Folder\\Level.txt", false);
                StreamWriter amt = new StreamWriter("Tabota_Folder\\Kg.txt", false);
                surname.Write("Дата:{0}", DateTime.Now.ToLongDateString());
                surname.WriteLine("Время:{0}", DateTime.Now.ToLongTimeString());
                surname.WriteLine("Птенец королевского_пингвина\r\nПтенец альбатроса\r\nСобака породы Самоед\r\nПлюшевая корова\r\nПомеранский шпиц\r\nКитайские шелковые куры\r\nПерсидская кошка\r\nСобака породы Чау-чау\r\nШиншилла\r\nГигантский ангорский кролик");
                surname.Close();
                for (int i = 1; i <= 10; i++)
                {
                    amt.WriteLine(rnd.Next(1, 100) + " килограмм(ов)");
                    age.WriteLine(rnd.Next(18, 65) + " лет");
                }
                amt.Close();
                age.Close();
            }
            catch (IOException e)
            {
                Console.WriteLine("Ошибка!");
                Console.WriteLine(e.ToString());
                Console.ReadLine();
                return;
            }
            Console.WriteLine("Файлы созданы.\r\nНажмите любую клавишу для чтения файла MexName.txt");
            Console.ReadKey(); Console.Clear();
            try
            {
                StreamReader surname = new StreamReader("Tabota_Folder\\MexName.txt", true);
                s = surname.ReadLine();
                while (s != null)
                {
                    Console.WriteLine(s);
                    s = surname.ReadLine();
                }
                surname.Close();

                Console.WriteLine("Нажмите любую клавишу для переходу к файлу Level.txt");
                Console.ReadKey(); Console.Clear();

                StreamReader age = new StreamReader("Tabota_Folder\\Level.txt", true);
                s = age.ReadLine();
                while (s != null)
                {
                    Console.WriteLine(s);
                    s = age.ReadLine();
                }
                age.Close();

                Console.WriteLine("Нажмите любую клавишу для переходу к файлу Kg.txt");
                Console.ReadKey(); Console.Clear();

                StreamReader amt = new StreamReader("Tabota_Folder\\Kg.txt", true);
                s = amt.ReadLine();
                while (s != null)
                {
                    Console.WriteLine(s);
                    s = amt.ReadLine();
                }
                amt.Close();

                Console.WriteLine("Нажмите любую клавишу для выхода из консоли.");
                Console.ReadKey();
            }
            catch (IOException e)
            {
                Console.WriteLine("Ошибка!");
                Console.WriteLine(e.ToString());
                Console.ReadLine();
                return;
            }
        }
    }
}
