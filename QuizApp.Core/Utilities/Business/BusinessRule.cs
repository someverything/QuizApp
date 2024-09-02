using QuizApp.Core.Utilities.Results.Abstract;
using QuizApp.Core.Utilities.Results.Concrete.ErrorResults;
using QuizApp.Core.Utilities.Results.Concrete.SuccessResults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizApp.Core.Utilities.Business
{
    public class BusinessRule
    {
        public static IResult CheckRules(params IResult[] logic)
        {
            foreach (var method in logic)
            {
                if (!method.Success)
                {
                    return new ErrorResult();
                }
            }
            return new SuccessResult();
        }
    }
}
