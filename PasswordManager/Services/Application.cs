namespace PasswordManager.Services
{
    using System;
    using System.IO;

    public class Application
    {
        private readonly IUserService _userService;
        private readonly IPasswordService _passwordService;
        private readonly FileService _fileService;
        
        public Application(IUserService userService, IPasswordService passwordService, FileService fileService)
        {
            _userService = userService;
            _passwordService = passwordService;
            _fileService = fileService;
        }

        public void Run()
        {
            if (!_fileService.FileExists())
            {
                _fileService.Create();
            }
            
            // @ToDo get user with userKey (encryption key)
            var currentUser = _userService.GetUsers();
            
            // @ToDo ask for password for user
            _passwordService.Run(currentUser);
            
            // prepare userdata
            // do while -> handleUserinput
            // cleanup()
        }
    }
}