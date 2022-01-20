namespace PasswordManager
{
    using System;
    using PasswordManager.Services;

    class Program
    {
        static void Main(string[] args)
        {
            var userService = new UserService();
            var fileService = new FileService();
            var passwordService = new PasswordService(fileService);
            var applicationService = new Application(userService, passwordService, fileService);
            applicationService.Run();
        }
        
        // create singleton test parse
    }
}