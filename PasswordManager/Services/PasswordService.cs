namespace PasswordManager.Services
{
    using System;
    using PasswordManager.Models;

    class PasswordService : IPasswordService
    {

        private readonly FileService _fileService;

        public PasswordService(FileService fileService)
        {
            _fileService = fileService;
        }

        public void Run(User user)
        {
            Console.WriteLine("{0} {1} {2}", user.EncryptionKey, user.PersonalData.FirstName, user.PersonalData.LastName);
            
            // @ToDo get passwords from user and try to encrypt with key 
            // if encryption false
            // -> "der key ist leider nicht richtig bitte anderen angeben" ask for key again;
            
            // if encryption true
            
            var url = Console.ReadLine();
            // @ToDo get url string with password
            // if url false
            // -> create new entry ... ark for password
            _fileService.Write("passwords");

            // if url true
            // @ToDo copy password into clipboard
            Console.WriteLine("password kopiert");
            
            
        }
        
        /*public void Run()
        {
            string serviceSection = _settings.GetValue<string>("AuthKey");
            Console.WriteLine(serviceSection);
            
            string fileName = "MyFile.json";
            string path = Path.Combine(Environment.CurrentDirectory, fileName);

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
            using (StreamReader sr = new StreamReader(path))
            {
                string json = sr.ReadToEnd();
                List<Password> list = JsonConvert.DeserializeObject<List<Password>>(json);

                if (list != null)
                {
                    pwList.AddRange(list);
                }
            }
            
            // write into json
            var convertedJson = JsonConvert.SerializeObject(pwList, Formatting.Indented);
            using (StreamWriter sw = new StreamWriter(path))
            {
                sw.WriteLine(convertedJson);
            };
        }*/
    }
}