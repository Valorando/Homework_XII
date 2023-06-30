/*Написать программу рекусривного обхожа каталогов на диске*/

void Recursive_Traversal(string full_path)
{
    try
    {
        string[] files = Directory.GetFiles(full_path);
        foreach (string file in files)
        {

            Console.WriteLine(file);
        }

        string[] directories = Directory.GetDirectories(full_path);
        foreach (string directory in directories)
        {
            Recursive_Traversal(directory);
        }
    }
    catch
    {
        Console.WriteLine();
        Console.WriteLine("\t\t\t==============================================");
        Console.WriteLine($"\t\t\tКаталог по пути {full_path} отсутствует.");
        Console.WriteLine("\t\t\t==============================================");
        Console.WriteLine();
    }
}



Console.ForegroundColor = ConsoleColor.Green;
while (true)
{
    try
    {
        Console.WriteLine();
        Console.WriteLine("\t\t\t==============================================");
        Console.WriteLine("\t\t\t     Система обхода каталогов на диске:");
        Console.WriteLine("\t\t\t==============================================");
        Console.WriteLine("\t\t\t*Введите 1 для просмотра содержимого каталога");
        Console.WriteLine("\t\t\t*Введите 2 для открытия подсказок");
        Console.WriteLine("\t\t\t*Введите 3 для выхода из программы");
        Console.Write("\t\t\t>Введите номер действия: ");
        int key;
        key = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("\t\t\t==============================================");
        Console.WriteLine();

        if (key == 1)
        {
            string drive;
            string? path;
            string name;
            string full_path;

            Console.WriteLine();
            Console.WriteLine("\t\t\t==============================================");
            Console.Write("\t\t\tВведите название диска: ");
            drive = Console.ReadLine();
            Console.WriteLine("\t\t\t==============================================");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("\t\t\t==============================================");
            Console.Write("\t\t\tВведите путь к каталогу: ");
            path = Console.ReadLine();
            Console.WriteLine("\t\t\t==============================================");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("\t\t\t==============================================");
            Console.Write("\t\t\tВведите название каталога: ");
            name = Console.ReadLine();
            Console.WriteLine("\t\t\t==============================================");
            Console.WriteLine();

            full_path = $"{drive}:\\{path}\\{name}";

            try
            {
                Console.WriteLine();
                Console.WriteLine("\t\t\t==============================================");
                Console.WriteLine($"\t\t\tСодержимое каталога {name} по пути {full_path}");
                Console.WriteLine("\t\t\t==============================================");
                Console.WriteLine();
                Recursive_Traversal(full_path);
                Console.WriteLine();
            }
            catch (DirectoryNotFoundException)
            {
                Console.WriteLine();
                Console.WriteLine("\t\t\t==============================================");
                Console.WriteLine($"\t\t\tКаталог по пути {full_path} отсутствует.");
                Console.WriteLine("\t\t\t==============================================");
                Console.WriteLine();
            }
        }

        if (key == 2)
        {
            Console.WriteLine();
            Console.WriteLine("\t\t\t========================================================================");
            Console.WriteLine("\t\t\t                            Подсказки:");
            Console.WriteLine("\t\t\t========================================================================");
            Console.WriteLine("\t\t\t1. Значения можно вводить как с большой, так и с маленькой буквы.");
            Console.WriteLine("\t\t\t2. Если путь к вашему каталогу не лежит через другие каталоги, то\n\t\t\tпри вводе пути просто нажмите Enter без ввода каких-либо значений.");
            Console.WriteLine("\t\t\t3. При вводе названия диска, пути к каталогу и его названию, убедитесь в\n\t\t\tправильности введёного вами значения.");
            Console.WriteLine("\t\t\t========================================================================");
            Console.WriteLine();
        }

        if (key == 3)
        {
            break;
        }
    }
    catch
    {
        
    }

}