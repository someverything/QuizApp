using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizApp.Core.Entities.Concrete
{
    public class User
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
        public bool EmailConfirmed { get; set; }
        public string ConfirmationToken { get; set; }
        public int LoginAttempt { get; set; }
    }
}
