using QuizApp.Core.DataAccess.EntityFramework;
using QuizApp.DataAccess.Abstract;
using QuizApp.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizApp.DataAccess.Concrete.EntityFramework
{
    public class EfUserDal : EfRepositoryBase<User,AppDbContext>, IUserDal
    {
    }
}
