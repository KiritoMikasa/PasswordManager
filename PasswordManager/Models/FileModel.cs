namespace PasswordManager.Models;

using System.Collections.Generic;

public class FileModel
{
    public User User { get; set; }
    
    public IList<Password> Passwords { get; set; }
}