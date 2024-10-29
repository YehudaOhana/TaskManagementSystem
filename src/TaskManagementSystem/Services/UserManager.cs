using TaskManagementSystem.Models;
// using System.Collections.Generic;
// using System.Linq;

namespace TaskManagementSystem.Services
{
    public class UserManager
    {
        private List<User> users = []; 

        public void AddUser(User user) => users.Add(user); 
        public void DeleteUser(int userId) => users.RemoveAll(u => u.UserId == userId);
        public User GetUser(int userId) => users.FirstOrDefault(u => u.UserId == userId);
        public List<User> GetAllUsers() => users; 
        
    }
}
