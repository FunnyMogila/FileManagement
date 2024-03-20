using System;

namespace FileManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            File myFile = new File("example.txt", FileType.File, 1024, "C:/Documents/");
            Console.WriteLine("Файл создан:");
            PrintFileInfo(myFile);

            while (true)
            {
                Console.WriteLine("Выберите действие:");
                Console.WriteLine("1. Копировать файл");
                Console.WriteLine("2. Переместить файл");
                Console.WriteLine("3. Переименовать файл");
                Console.WriteLine("4. Выйти");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.WriteLine("Введите новый путь для копирования:");
                        string newPath = Console.ReadLine();
                        File copiedFile = myFile.Copy(newPath);
                        Console.WriteLine("Файл скопирован:");
                        PrintFileInfo(copiedFile);
                        break;
                    case "2":
                        Console.WriteLine("Введите новый путь для перемещения:");
                        string newLocation = Console.ReadLine();
                        myFile.Move(newLocation);
                        Console.WriteLine("Файл перемещен:");
                        PrintFileInfo(myFile);
                        break;
                    case "3":
                        Console.WriteLine("Введите новое имя файла:");
                        string newName = Console.ReadLine();
                        myFile.Rename(newName);
                        Console.WriteLine("Файл переименован:");
                        PrintFileInfo(myFile);
                        break;
                    case "4":
                        return;
                    default:
                        Console.WriteLine("Неверный выбор. Пожалуйста, выберите снова.");
                        break;
                }
            }
        }

        static void PrintFileInfo(File file)
        {
            Console.WriteLine($"Name: {file.Name}");
            Console.WriteLine($"Category: {file.Category}");
            Console.WriteLine($"Size: {file.Size} bytes");
            Console.WriteLine($"Location: {file.Location}");
        }
    }
}

