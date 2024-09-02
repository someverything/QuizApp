using QuizApp.Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizApp.Entities.Concrete
{
    public class Question : IEntity
    {
        public int Id { get; set; }
        public string Quiz { get; set; }
    }
}
