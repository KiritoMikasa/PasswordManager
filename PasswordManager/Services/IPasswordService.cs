namespace PasswordManager.Services
{
    using PasswordManager.Models;

    public interface IPasswordService
    {
        public void Run(User user);
    }
}