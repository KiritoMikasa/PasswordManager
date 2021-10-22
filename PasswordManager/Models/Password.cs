namespace PasswordManager.Models
{
    using System.Text.Json.Serialization;

    public class Password
    {
        public string Id { get; set; }
        
        public string UserLogin { get; set; }
        
        public string UserPassword { get; set; }
    }
}