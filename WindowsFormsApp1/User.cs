using System.Linq;
using System.Text.RegularExpressions;

namespace WindowsFormsApp1
{
    public class User
    {
        public string Login { get; set; }
        
        public string Name { get; set; }
        
        public string Email { get; set; }
        
        public string Password { get; set; }
        
        public decimal Record { get; set; }
        
        public static bool CheckLogin(string login)
        {
            return !string.IsNullOrEmpty(login) && 
                   Database.IsLoginUnique(login) && 
                   login.All(c => c >= 'a' && c <= 'z' || c >= 'A' && c <= 'Z');
        }
        
        public static bool CheckName(string name)
        {
            return !string.IsNullOrEmpty(name) && 
                   char.IsUpper(name.First()) && 
                   name.All(c => c >= 'a' && c <= 'z' || c >= 'A' && c <= 'Z');
        }

        public static bool CheckEmail(string email)
        {
            return !string.IsNullOrEmpty(email) && 
                   Regex.IsMatch(email, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", RegexOptions.IgnoreCase);
        }

        public static bool CheckPassword(string password, string repeatPassword)
        {
            var requiredSymbols = new [] {'.', ',', '!', '$', '%', '?'};
            
            return !string.IsNullOrEmpty(password) && 
                   password == repeatPassword && 
                   password.Length > 8 && 
                   password.Any(char.IsUpper) && 
                   password.Any(char.IsLower) &&
                   password.Any(char.IsDigit) &&
                   password.Any(requiredSymbols.Contains);
        }
    }
}