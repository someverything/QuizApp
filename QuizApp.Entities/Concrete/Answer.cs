using QuizApp.Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizApp.Entities.Concrete
{
    public class Answer : IEntity
    {
        public int Id { get; set; }
        public string Variant { get; set; }
        public int QuestionId { get; set; }
        public Question Question { get; set; }
    }
}
