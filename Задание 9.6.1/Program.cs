using System;
using System.IO;

namespace Task
{
    public class MyException : Exception 
        { 
            public MyException(string message) : base(message) 
            { 

            }
        }

    class Program
    {
        static void Main(string[] args)
        {
            Exception[] exceptions = new Exception[]
            {
                new ArgumentNullException("Параметр не может быть null"),
                new FormatException("Значение введено некорректно"),
                new FileNotFoundException("Файл не существует"),
                new DriveNotFoundException("Диск недоступен или не существует"),
                new DirectoryNotFoundException("Недопустимая часть пути к каталогу")
            };

            foreach (var exception in exceptions)
            {
                try
                {
                    throw exception;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Поймано исключение: {ex.Message}");
                }
                finally
                {
                    Console.WriteLine("Блок finally был выполнен");
                }
            }
        }
    }
}