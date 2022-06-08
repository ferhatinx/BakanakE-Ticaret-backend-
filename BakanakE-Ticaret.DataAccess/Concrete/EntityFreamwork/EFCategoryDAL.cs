using BakanakE_Ticaret.Core.DataAccess.EntityFreamwork;
using BakanakE_Ticaret.DataAccess.Abstract;
using BakanakE_Ticaret.Entities.Concrete;

namespace BakanakE_Ticaret.DataAccess.Concrete.EntityFreamwork
{
    public class EFCategoryDAL : EFEntityRepositoryBase<Category, NorthwindContext>, ICategoryDAL
    {

    }
}
