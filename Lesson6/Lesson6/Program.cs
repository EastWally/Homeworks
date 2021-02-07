using System;
using System.ComponentModel;
using System.Diagnostics;

namespace Lesson6
{
    class Program
    {
        static void Main(string[] args)
        {
            GetListOfProcesses();

            while (true)
            {
                Console.WriteLine(("").PadRight(40, '='));
                Console.Write($"/L - вывод списка процессов\n/ID идентификатор процесса - остановка процесса\n/N имя процесса - остановка процесса\n/q - выход\n: ");
                string[] inputLine = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                if (inputLine.Length == 1)
                {
                    if (inputLine[0] == "/L")
                        GetListOfProcesses();
                    else if (inputLine[0] == "/q")
                        return;
                }

                if (inputLine.Length == 2)
                {
                    if (inputLine[0] == "/N")
                        KillProcessByName(inputLine[1]);
                    else if (inputLine[0] == "/ID")
                    {
                        if (int.TryParse(inputLine[1], out int processId))
                            KillProcessByID(processId);
                    }
                }
            }
        }

        static void GetListOfProcesses()
        {
            Console.WriteLine($"{"Id",-10} {"Имя процесса"}");
            Console.WriteLine(("").PadRight(40, '='));
            Process[] allProcesses = Process.GetProcesses();
            foreach (var process in allProcesses)
            {
                Console.WriteLine($"{process.Id,-10} {process.ProcessName}");
            }
        }
                
        static void KillProcessByID(int processId)
        {
            try
            {
                Process selectedProcess = Process.GetProcessById(processId);
                selectedProcess.Kill();
                Console.WriteLine($"Процесс {selectedProcess.Id} {selectedProcess.ProcessName} остановлен.");
            }
            catch (InvalidOperationException opExp)
            {
                Console.WriteLine($"Процесс не был запущен этим объектом. {opExp.Message}");
            }
            catch (ArgumentException argExp)
            {
                Console.WriteLine($"Процесс {processId} не выполняется. {argExp.Message}");
            }
            catch (Win32Exception winExp)
            {
                Console.WriteLine($"Связанный процесс не может быть завершен. {winExp.Message}");
            }
            catch (NotSupportedException notSupExp)
            {
                Console.WriteLine($"Вы пытаетесь остановить процесс на удаленном компьютере. {notSupExp.Message}");
            }
        }

        static void KillProcessByName(string processName)
        {
            Process[] arrayOfProcesses = Process.GetProcessesByName(processName);
            {
                foreach (var process in arrayOfProcesses)
                {
                    try
                    {
                        process.Kill();
                        Console.WriteLine($"Процесс {process.Id} {process.ProcessName} остановлен.");
                    }
                    catch (Win32Exception winExp)
                    {
                        Console.WriteLine($"Связанный процесс не может быть завершен. {winExp.Message}");
                    }
                    catch (NotSupportedException notSupExp)
                    {
                        Console.WriteLine($"Вы пытаетесь остановить процесс на удаленном компьютере. {notSupExp.Message}");
                    }
                }
            }
        }
    }
}
