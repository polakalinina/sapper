using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace WindowsFormsApp1
{
    public static class Database
    {
        private const string FileName = "users.txt";
        private static readonly List<User> Users;

        static Database()
        {
            Users = new List<User>();
            
            if (!File.Exists(FileName))
            {
                var fileStream = File.Create(FileName);
                fileStream.Dispose();
            }
            
            var lines = File.ReadLines(FileName);

            foreach (var line in lines)
            {
                var parts = line.Split(';');

                var user = new User
                {
                    Login = parts[0],
                    Name = parts[1],
                    Email = parts[2],
                    Password = parts[3],
                    Record = decimal.Parse(parts[4])
                };

                var prviousUserRecord = Users.FirstOrDefault(u => u.Login == user.Login);
                if (prviousUserRecord != null)
                {
                    Users.Remove(prviousUserRecord);
                }
                
                Users.Add(user);
            }
        }
        
        public static bool IsLoginUnique(string login)
        {
            return Users.All(user => user.Login != login);
        }

        public static User GetUser(string login, string password)
        {
            return Users.FirstOrDefault(user => user.Login == login &&
                                                user.Password == password);
        }

        public static void AddUser(User newUser)
        {
            Users.Add(newUser);

            var writer = File.AppendText(FileName);
            writer.WriteLineAsync($"{newUser.Login};{newUser.Name};{newUser.Email};{newUser.Password};{newUser.Record}");
            writer.Close();
        }
        
        public static void Save(User user)
        {
            var writer = File.AppendText(FileName);
            writer.WriteLineAsync($"{user.Login};{user.Name};{user.Email};{user.Password};{user.Record}");
            writer.Close();
        }
    }
}