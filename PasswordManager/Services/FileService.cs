namespace PasswordManager.Services
{
    using System;
    using System.IO;

    public class FileService
    {
        private const string FileName = "MyFile.json";
        private readonly string _path;

        public FileService()
        {
            _path = Path.Combine(Environment.CurrentDirectory, FileName);
        }

        // maybe parse path?
        public bool FileExists()
        {
            return File.Exists(_path);
        }

        public void Create()
        {
            /*File.CreateText(_path);*/
            Console.WriteLine("Created new file: {0}", FileName);
        }
        
        public void Write(string data)
        {
            Console.WriteLine("write {0} into json", data);
            /*using (StreamReader sr = new StreamReader(Path))
            {
                string json = sr.ReadToEnd();
                List<Password> list = JsonConvert.DeserializeObject<List<Password>>(json);

                if (list != null)
                {
                    pwList.AddRange(list);
                }
            }
            
            var convertedJson = JsonConvert.SerializeObject(pwList, Formatting.Indented);
            using (StreamWriter sw = new StreamWriter(Path))
            {
                sw.WriteLine(convertedJson);
            };*/
        }
    }
}