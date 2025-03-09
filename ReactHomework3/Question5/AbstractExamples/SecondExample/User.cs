using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace ReactHomework3.Question5.AbstractExamples.SecondExample
{
    public abstract class User
    {
        public string Id { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Phone { get; set; }
        public string RoleName { get; set; }
        public DateTime CreatedTime { get; set; }
        public DateTime UpdatedTime { get; set; }
        public bool IsActive { get; set; }
        public User()
        {
            CreatedTime = DateTime.UtcNow;
        }
        public virtual bool Login(string email, string password)
        {
            if(Email == email && Password == password)
                return true;
            else
                return false;
        }
    }
}
