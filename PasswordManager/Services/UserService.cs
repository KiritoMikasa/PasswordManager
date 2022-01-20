namespace PasswordManager.Services
{
    using System;
    using PasswordManager.Models;

    class UserService : IUserService
    {
        private readonly User _user = new()
        {
            EncryptionKey = "someKey",
            PersonalData = new PersonalData
            {
                FirstName = "Dong",
                LastName = "Nguyen"
            }
        };

        public User GetUsers()
        {
            Console.WriteLine("please enter userName");
            var userName = Console.ReadLine();
            
            // @ToDo find user
            // @ToDo check for typo suggest other user with almost same name

            // @ToDo enter encription key from user
            Console.WriteLine("please enter encryptionKey");
            var encryptionKey = Console.ReadLine();
            
            return _user;
        }
    }
}