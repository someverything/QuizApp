using QuizApp.Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizApp.Entities.Concrete
{
    public class FriendAnswer : IEntity
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public int CorrectCount { get; set; }
        public int UserAnswerId { get; set; }
        public UserAnswer UserAnswer { get; set; }
    }
}
