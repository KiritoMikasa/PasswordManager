namespace PasswordManager.Models
{
    using System;

    public class User
    {
        public PersonalData PersonalData { get; set; }
        
        public string EncryptionKey { get; set; }
    }
}