using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Concrete.EntitiyFramework.Contexts;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntitiyFramework
{
    public class EfUserDal : EfEntityRepositoryBase<User, NorthwindContext>, IUserDAL

    {
        public List<OperationClaim> GetClaims(User user)
        {
            using (var context=new NorthwindContext())
            {
                var result=from operationClaim in context.OperationClaims
                           join userOperationsClaim in context.UserOperationClaims
                            on operationClaim.Id equals userOperationsClaim.OperationClaimId
                           where userOperationsClaim.UserId==user.Id
                           select new OperationClaim { Id=operationClaim.Id,Name=operationClaim.Name};

                return result.ToList();
            }
        }
    }
}
