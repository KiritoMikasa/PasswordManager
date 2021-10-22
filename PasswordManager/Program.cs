namespace PasswordManager
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using Newtonsoft.Json;
    using PasswordManager.Models;

    class Program
    {

        static void Main(string[] args)
        {
            string path = @"/home/dong/Projects/PasswordManager/myFile.json";

            if (!File.Exists(path))
            {
                File.CreateText(path);
                Console.WriteLine("No file found");
                Console.WriteLine("Created new file");
            }

            List<Password> pwList = new List<Password>();
            
            do {
                Console.WriteLine("enter entry: ");
                string id = Console.ReadLine();

                if (id is "exit" or "q")
                {
                    break;
                }

                Console.WriteLine("enter login: ");
                string login = Console.ReadLine();
                
                if (login is "exit" or "q")
                {
                    break;
                }

                Console.WriteLine("enter password: ");
                string password = Console.ReadLine();
                
                if (password is "exit" or "q")
                {
                    break;
                }

                pwList.Add(new Password
                {
                    Id = id,
                    UserLogin = login,
                    UserPassword = password
                });
            } while (!(Console.KeyAvailable && Console.ReadKey(true).Key == ConsoleKey.Escape));
            
            Console.WriteLine("write file");
            
            // read existing json
            using StreamReader sr = new StreamReader(path);
            string json = sr.ReadToEnd();
            List<Password> list = JsonConvert.DeserializeObject<List<Password>>(json);

            if (list != null)
            {
                pwList.AddRange(list);
            }

            // write into json
            var convertedJson = JsonConvert.SerializeObject(pwList, Formatting.Indented);
            using StreamWriter sw = new StreamWriter(path);
            sw.WriteLine(convertedJson);
        }
    }
}