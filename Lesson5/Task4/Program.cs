using System;
using System.IO;
using System.Collections.Generic;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите путь: ");
            string rootDir = Console.ReadLine();
            string fileName = "Dirs.txt", fileNameRecursion = "DirsRecursion.txt";
            if (File.Exists(fileNameRecursion))
                File.Delete(fileNameRecursion);
            if (File.Exists(fileName))
                File.Delete(fileName);
            GetTreeDirRecursion(rootDir, fileNameRecursion);
            GetTreeDir(rootDir, fileName);
            Console.WriteLine($"Результат выполнения метода с рекурсией записан в файл {fileNameRecursion}");
            Console.WriteLine($"Результат выполнения метода без рекурсии записан в файл {fileName}");
            Console.ReadKey();
        }

        //Получить дерево каталогов без рекурсии
        static void GetTreeDir(string path, string outputFileName)
        {
            List<string> dirs = new List<string>();
            dirs.Add(path);
            while (dirs.Count > 0)
            {
                string currentDir = dirs[0];
                dirs.RemoveAt(0);

                File.AppendAllText(outputFileName, currentDir + "\n");
                string[] subDirs = Directory.GetDirectories(currentDir); 
                string[] files = Directory.GetFiles(currentDir);
                File.AppendAllLines(outputFileName, files);

                foreach (var dir in subDirs) 
                    dirs.Add(dir);
            }
        }

        //Получить дерево каталогов с рекурсией
        static void GetTreeDirRecursion(string path, string outputFileName)
        {
            string[] directories = Directory.GetDirectories(path);
            string[] files = Directory.GetFiles(path);

            foreach (var dir in directories)
            {
                File.AppendAllText(outputFileName, dir + "\n");
                GetTreeDirRecursion(dir, outputFileName);                
            }
            File.AppendAllLines(outputFileName, files);
        }
    }
}
