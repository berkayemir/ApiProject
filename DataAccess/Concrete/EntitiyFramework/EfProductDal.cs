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
    public class EfProductDal: EfEntityRepositoryBase<Product,NorthwindContext>,IProductDAL
    {
    }
}
