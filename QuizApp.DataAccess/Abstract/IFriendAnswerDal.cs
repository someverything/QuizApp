using QuizApp.Core.DataAccess;
using QuizApp.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizApp.DataAccess.Abstract
{
    public interface IFriendAnswerDal : IRepositoryBase<FriendAnswer>
    {
    }
}
