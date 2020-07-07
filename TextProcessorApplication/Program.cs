using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using TextProcessorApplication.DataService;

namespace TextProcessorApplication
{
    sealed class Program
    {
        static void Main(string[] args)
        {
            using (var context = new Context())
            {
                var dictionaryService = new DictionaryService(context);
                if (args.Length < 1)
                {
                    while (true)
                    {
                        string prefix = String.Empty;
                        var key = Console.ReadKey();
                        if (key.Key == ConsoleKey.Escape || key.Key == ConsoleKey.Enter)
                            return;

                        prefix += key.KeyChar;
                        prefix += Console.ReadLine();
                        if(string.IsNullOrWhiteSpace(prefix))
                            return;
                        dictionaryService.Read(prefix);
                    }
                }

                else if (args.Length == 1)
                {
                    var command = args[0];
                    if (command == "create")
                    {
                        Console.WriteLine("Enter file path");
                        dictionaryService.Create(Console.ReadLine());
                    }
                    else if (command == "update")
                    {
                        Console.WriteLine("Enter file path");
                        dictionaryService.Update(Console.ReadLine());
                    }
                    else if (command == "delete")
                    {
                        dictionaryService.Delete();
                    }
                }
            }
        }
    }
}
