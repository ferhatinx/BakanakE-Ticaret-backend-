using BakanakE_Ticaret.Core.DataAccess.EntityFreamwork;
using BakanakE_Ticaret.DataAccess.Abstract;
using BakanakE_Ticaret.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BakanakE_Ticaret.DataAccess.Concrete.EntityFreamwork
{
    public class EFProductDAL:EFEntityRepositoryBase<Product,NorthwindContext>, IProductDAL
    {

    }
}
